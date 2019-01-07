using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Repository.StoredProcedures
{
    public abstract class SqlProcedure : ProcedureBase
    {
        private object[] _parameterValues;
        private string[] _parameterOutput;
        private string _returnParameter;
        private KeyValuePair<string, object>[] _parameters;
        private ProcedureParamObject[] _typedParameters;
        protected string ConnectionString;
        protected string ProcedureName;

        public SqlProcedure(string name)
        {
            ProcedureName = name;
        }

        public override IProcedure Initialize(params ProcedureParamObject[] list)
        {
            _typedParameters = list;
            return this;
        }

        public sealed override IProcedure Initialize(params object[] list)
        {
            _parameterValues = list;
            return this;
        }

        public sealed override IProcedure Initialize(params KeyValuePair<string, object>[] list)
        {
            _parameters = list;
            return this;
        }



        public sealed override ProcedureResult Execute()
        {
            ProcedureResult result;
            using (var con = new SqlConnection(ConnectionString))
            {
                using (var cmd = new SqlCommand(ProcedureName, con) { CommandType = CommandType.StoredProcedure })
                {
                    if (_timeout == null)
                    {
                        _timeout = 30;
                    }

                    cmd.CommandTimeout = _timeout.GetValueOrDefault();
                    con.Open();
                    AddParameters(cmd);
                    SetOutputParameters(cmd);
                    SetReturnParameter(cmd);
                    result = ReadData(cmd);
                    con.Close();
                }
            }
            return result;
        }

        protected virtual void AddParameters(SqlCommand cmd)
        {
            if (_parameterValues != null)
            {
                SqlCommandBuilder.DeriveParameters(cmd);
                for (var i = 1; i < cmd.Parameters.Count; i++)
                {
                    if (i - 1 >= _parameterValues.Length)
                        throw new ArgumentException("Too few parameters supplied! Missing: " + cmd.Parameters[i].ParameterName);
                    cmd.Parameters[i].Value = _parameterValues[i - 1];
                }
            }
            if (_parameters != null)
            {
                foreach (var p in _parameters)
                    cmd.Parameters.Add(new SqlParameter(p.Key, p.Value));
            }

            if (_typedParameters != null)
            {
                foreach (ProcedureParamObject param in _typedParameters)
                {
                    SqlParameter sqlParam = new SqlParameter(param.ParamName, param.Type);
                    sqlParam.Value = param.Data;

                    if (param.Type == SqlDbType.Structured)
                    {
                        sqlParam.TypeName = ((DataTable)param.Data).TableName;
                    }

                    cmd.Parameters.Add(sqlParam);
                }
            }
        }

        protected virtual void SetOutputParameters(SqlCommand cmd)
        {
            if (_parameterOutput != null)
                foreach (var p in _parameterOutput)
                {
                    if (cmd.Parameters.Contains(p))
                    {
                        cmd.Parameters[p].Direction = ParameterDirection.Output;
                        if (cmd.Parameters[p].Value is decimal)
                        {
                            cmd.Parameters[p].Scale = 3;
                            cmd.Parameters[p].Precision = 19;
                        }
                    }
                }
        }
        protected virtual void SetReturnParameter(SqlCommand cmd)
        {
            if (_returnParameter != null)
                if (cmd.Parameters.Contains(_returnParameter))
                {
                    cmd.Parameters[_returnParameter].Direction = ParameterDirection.ReturnValue;
                    if (cmd.Parameters[_returnParameter].Value is decimal)
                    {
                        cmd.Parameters[_returnParameter].Scale = 3;
                        cmd.Parameters[_returnParameter].Precision = 19;
                    }
                }
        }

        protected virtual ProcedureResult ReadData(SqlCommand cmd)
        {
            var result = new ProcedureResult();
            using (var reader = cmd.ExecuteReader())
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        var row = new Dictionary<string, object>();
                        var fieldCount = Enumerable.Range(0, reader.FieldCount);
                        foreach (var i in fieldCount)
                        {
                            var key = reader.GetName(i);
                            if (!row.ContainsKey(key))
                            {
                                row.Add(key, reader.GetValue(i));
                            }
                        }
                        result.DataRows.Add(row);
                    }

                    result.Results.Add(result.DataRows.ToList());

                    while (reader.NextResult())
                    {
                        result.DataRows.Clear();
                        while (reader.Read())
                        {
                            var row = new Dictionary<string, object>();
                            var fieldCount = Enumerable.Range(0, reader.FieldCount);
                            foreach (var i in fieldCount)
                            {
                                var key = reader.GetName(i);
                                if (!row.ContainsKey(key))
                                {
                                    row.Add(key, reader.GetValue(i));
                                }
                            }
                            result.DataRows.Add(row);
                        }

                        result.Results.Add(result.DataRows.ToList());
                    }
                }

                foreach (SqlParameter p in cmd.Parameters)
                    result.Parameters.Add(p.ParameterName, p.Value);
            }
            return result;
        }

        public override IProcedure OutputParameters(params string[] list)
        {
            _parameterOutput = list;
            return this;
        }

        public override IProcedure ReturnParameter(string parameter)
        {
            _returnParameter = parameter;
            return this;
        }
    }
}
