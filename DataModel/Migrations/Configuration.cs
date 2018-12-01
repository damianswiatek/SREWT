namespace DataModel.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DataModel.Container.DatabaseContainer>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataModel.Container.DatabaseContainer context)
        {

            //#region #### Merchant 1 - DELL ####


            //string merchant1Id = "1537a585-3327-4e5c-835e-69f1ac92862c";
            //string logo1Id = "260471e9-ec4c-46df-ba56-2aac6664da03";
            //string bonusProgram1Id = "26261a51-0e0a-46bc-b135-9a7124e45ada";
            //string backgroundPicture1Id = "bea87de4-0e10-4ea7-a75b-420efd115881";
            //string merchantPOS11Id = "e93569b2-3625-45a5-a485-b8746cf7bf2e";

            //string rewardId11 = "7d33d46b-b6ef-425d-97d1-f649097d2834";
            //string rewardId12 = "bc7932fc-50be-422c-9ad2-c0216fb115b6";
            //string rewardId13 = "ce37a9d1-ca9e-443f-9775-5045b0372b08";

            //DateTime dateMerchant1 = new DateTime(2017, 7, 12);
            //DateTime dateBonusProgram1 = new DateTime(2017, 9, 1);
            //DateTime dateMerchantPOS11 = new DateTime(2017, 8, 19);
            //DateTime dateReward11 = new DateTime(2017, 9, 1);
            //DateTime dateReward12 = new DateTime(2017, 8, 11);
            //DateTime dateReward13 = new DateTime(2017, 8, 12);

            //Merchant merchant1 = new Merchant()
            //{
            //    Id = new Guid(merchant1Id),
            //    X_CreatedDate = dateMerchant1,
            //    X_LastUpdateDate = dateMerchant1,
            //    Type = "Electronic Store",
            //    Name = "DELL",
            //    MerchantPOSCodes = "[\"CODE11\"]",
            //    LogoId = new Guid(logo1Id)
            //};

            //BonusProgram bonusProgram1 = new BonusProgram()
            //{
            //    Id = new Guid(bonusProgram1Id),
            //    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In ultricies ac leo ut placerat. Cras a tortor tristique, ullamcorper libero fermentum, pretium ipsum. Suspendisse potenti. Donec tristique tincidunt ante non lobortis. ",
            //    Ratio = 10,
            //    BackgroundPictureId = new Guid(backgroundPicture1Id),
            //    PointsLifetime = 30,
            //    Merchant_Id = new Guid(merchant1Id),
            //    SpecialOfferTitle = "Duis aliquet elit ",
            //    SpecialOfferDescription = " Etiam sagittis pretium felis, vel dignissim elit tempor sed. Nulla facilisi. Sed non fermentum metus, in vestibulum dui. Nam porta nec felis quis lobortis.",
            //    X_CreatedDate = dateBonusProgram1,
            //    X_LastUpdateDate = dateBonusProgram1,
            //    IsActive = true,
            //    ActivationDate = dateBonusProgram1
            //};

            //Reward reward11 = new Reward()
            //{
            //    Id = new Guid(rewardId11),
            //    Description = "In hac habitasse platea dictumst. Mauris scelerisque porttitor tincidunt. Mauris et malesuada dolor.",
            //    NeededPoints = 3000,
            //    Type = Enums.RewardType.GOLD,
            //    BonusProgram_Id = new Guid(bonusProgram1Id),
            //    X_CreatedDate = dateReward11,
            //    X_LastUpdateDate = dateReward11,
            //    Title = "Eget luctus justo malesuada"
            //};

            //Reward reward12 = new Reward()
            //{
            //    Id = new Guid(rewardId12),
            //    Description = "Sed sagittis diam augue, eget vulputate lectus varius tempus. Proin iaculis elit at tortor tincidunt ultrices.",
            //    NeededPoints = 2000,
            //    Type = Enums.RewardType.SILVER,
            //    BonusProgram_Id = new Guid(bonusProgram1Id),
            //    X_CreatedDate = dateReward12,
            //    X_LastUpdateDate = dateReward12,
            //    Title = "Mauris eget lectus"
            //};

            //Reward reward13 = new Reward()
            //{
            //    Id = new Guid(rewardId13),
            //    Description = "Sed ex lorem, dapibus ac egestas sit amet, consectetur pellentesque urna. Aenean porttitor, arcu quis maximus ornare,",
            //    NeededPoints = 1000,
            //    Type = Enums.RewardType.BRONZE,
            //    BonusProgram_Id = new Guid(bonusProgram1Id),
            //    X_CreatedDate = dateReward13,
            //    X_LastUpdateDate = dateReward13,
            //    Title = "Sed pharetra"
            //};

            //MerchantPOS merchantPOS11 = new MerchantPOS()
            //{
            //    Id = new Guid(merchantPOS11Id),
            //    Merchant_Id = new Guid(merchant1Id),
            //    NotificationName = "CODE11",
            //    City = "Wroc³aw",
            //    Street = "Komandorska",
            //    PostalCode = "90-359",
            //    Lat = 51.145579,
            //    Lon = 17.142640,
            //    X_CreatedDate = dateMerchantPOS11,
            //    X_LastUpdateDate = dateMerchantPOS11,
            //};

            //context.Merchants.AddOrUpdate(x => x.Id, merchant1);
            //context.BonusPrograms.AddOrUpdate(x => x.Id, bonusProgram1);
            //context.Rewards.AddOrUpdate(x => x.Id, reward11);
            //context.Rewards.AddOrUpdate(x => x.Id, reward12);
            //context.Rewards.AddOrUpdate(x => x.Id, reward13);
            //context.MerchantPOSes.AddOrUpdate(x => x.Id, merchantPOS11);

            //#endregion


            //#region #### Merchant 2 - H&M ####

            //string merchant2Id = "6d2de478-9866-4b38-b1a6-a2d5f833fe13";
            //string logo2Id = "b62b874e-0c93-4493-aecb-878a06fad57d";
            //string bonusProgram2Id = "bf113fc4-40b9-4e65-8f86-ab39debf5678";
            //string backgroundPicture2Id = "4e100d37-f9ad-4714-ac12-6636b590e923";
            //string merchantPOS21Id = "1717d500-64fa-4326-8352-1dfe95cc6e1a";
            //string merchantPOS22Id = "4e80ae6f-33c3-4fe4-8262-64895aca24ba";

            //string rewardId21 = "35f5f93c-d450-41a8-8b11-b6ed99083dc2";
            //string rewardId22 = "70738c36-8d62-4f1f-9598-4de14095649d";
            //string rewardId23 = "4da082cb-2538-45b9-b675-c1ed957f9143";

            //DateTime dateMerchant2 = new DateTime(2017, 8, 10);
            //DateTime dateBonusProgram2 = new DateTime(2017, 9, 2);
            //DateTime dateMerchantPOS21 = new DateTime(2017, 8, 12);
            //DateTime dateMerchantPOS22 = new DateTime(2017, 8, 20);
            //DateTime dateReward21 = new DateTime(2017, 9, 1);
            //DateTime dateReward22 = new DateTime(2017, 8, 11);
            //DateTime dateReward23 = new DateTime(2017, 8, 12);

            //Merchant merchant2 = new Merchant()
            //{
            //    Id = new Guid(merchant2Id),
            //    X_CreatedDate = dateMerchant2,
            //    X_LastUpdateDate = dateMerchant2,
            //    MerchantPOSCodes = "[\"CODE21\", \"CODE22\"]",
            //    Name = "H&M",
            //    Type = "Clothes Store",
            //    LogoId = new Guid(logo2Id)
            //};

            //BonusProgram bonusProgram2 = new BonusProgram()
            //{
            //    Id = new Guid(bonusProgram2Id),
            //    Description = "Vivamus ultrices nulla nec risus eleifend convallis. Etiam vestibulum, tortor a pharetra mattis, nisi augue consequat est, eget consequat dui nisl quis nulla.",
            //    Ratio = 10,
            //    BackgroundPictureId = new Guid(backgroundPicture2Id),
            //    PointsLifetime = 20,
            //    Merchant_Id = new Guid(merchant2Id),
            //    SpecialOfferTitle = "Duis aliquet elit ",
            //    SpecialOfferDescription = "Ssem odio, sit amet volutpat ligula maximus vitae. Duis aliquet elit sed molestie semper.",
            //    X_CreatedDate = dateBonusProgram2,
            //    X_LastUpdateDate = dateBonusProgram2,
            //    ActivationDate = dateBonusProgram2,
            //    IsActive = true
            //};

            //Reward reward21 = new Reward()
            //{
            //    Id = new Guid(rewardId21),
            //    Description = " Integer accumsan ante nec suscipit eleifend. Quisque tempor nunc et nunc laoreet sollicitudin. Curabitur quis porta velit, at semper enim",
            //    NeededPoints = 3000,
            //    Type = Enums.RewardType.GOLD,
            //    BonusProgram_Id = new Guid(bonusProgram2Id),
            //    X_CreatedDate = dateReward21,
            //    X_LastUpdateDate = dateReward21,
            //    Title = "Lorem ipsum dolor sit"
            //};

            //Reward reward22 = new Reward()
            //{
            //    Id = new Guid(rewardId22),
            //    Description = "Etiam tortor purus, venenatis ac neque convallis, tristique condimentum libero. Etiam lorem nisl, ultricies quis aliquam venenatis, porta ",
            //    NeededPoints = 2000,
            //    Type = Enums.RewardType.SILVER,
            //    BonusProgram_Id = new Guid(bonusProgram2Id),
            //    X_CreatedDate = dateReward22,
            //    X_LastUpdateDate = dateReward22,
            //    Title = "Vivamus gravida"
            //};

            //Reward reward23 = new Reward()
            //{
            //    Id = new Guid(rewardId23),
            //    Description = "el magna. Nam pellentesque tortor sed euismod sollicitudin. Vivamus a tempus mauris. Donec velit nisl, cursus vel erat non, luctus egestas mi. In nisi metus, elementum a venenatis et, porta quis orci.",
            //    NeededPoints = 1000,
            //    Type = Enums.RewardType.BRONZE,
            //    BonusProgram_Id = new Guid(bonusProgram2Id),
            //    X_CreatedDate = dateReward23,
            //    X_LastUpdateDate = dateReward23,
            //    Title = "Aenean non odio"
            //};

            //MerchantPOS merchantPOS21 = new MerchantPOS()
            //{
            //    Id = new Guid(merchantPOS21Id),
            //    Merchant_Id = new Guid(merchant2Id),
            //    NotificationName = "CODE21",
            //    City = "Wroc³aw",
            //    Street = "Kielczowska",
            //    PostalCode = "90-359",
            //    Lat = 51.101950,
            //    Lon = 17.036666,
            //    X_CreatedDate = dateMerchantPOS21,
            //    X_LastUpdateDate = dateMerchantPOS21,
            //};

            //MerchantPOS merchantPOS22 = new MerchantPOS()
            //{
            //    Id = new Guid(merchantPOS22Id),
            //    Merchant_Id = new Guid(merchant2Id),
            //    NotificationName = "CODE22",
            //    City = "Wroc³aw",
            //    Street = "Ruska",
            //    PostalCode = "90-359",
            //    Lat = 51.101562,
            //    Lon = 17.029231,
            //    X_CreatedDate = dateMerchantPOS22,
            //    X_LastUpdateDate = dateMerchantPOS22,
            //};

            //context.Merchants.AddOrUpdate(x => x.Id, merchant2);
            //context.BonusPrograms.AddOrUpdate(x => x.Id, bonusProgram2);
            //context.Rewards.AddOrUpdate(x => x.Id, reward21);
            //context.Rewards.AddOrUpdate(x => x.Id, reward22);
            //context.Rewards.AddOrUpdate(x => x.Id, reward23);
            //context.MerchantPOSes.AddOrUpdate(x => x.Id, merchantPOS21);
            //context.MerchantPOSes.AddOrUpdate(x => x.Id, merchantPOS22);

            //#endregion


            //#region #### Merchant 3 - ZARA ####


            //string merchant3Id = "d5f32aa6-335b-4d97-bd32-260777b039cd";
            //string logo3Id = "041ec0f8-1c3b-4403-a4a6-aeed0e2f80ae";
            //string bonusProgram3Id = "7bd7845b-983b-48eb-8781-8994299de8cc";
            //string backgroundPicture3Id = "d490fa96-a462-4539-8a82-56e9928a4338";
            //string merchantPOS31Id = "fe38afd3-2fa6-406d-9fd4-7e7682af4dd8";
            //string merchantPOS32Id = "ff0279c5-079b-455b-ab37-a0cc51d931e2";
            //string merchantPOS33Id = "93c83b74-aa91-4d88-9ec1-9aaab4fec4d4";

            //string rewardId31 = "352f80a9-9dd0-4e4f-a544-28581819c38a";
            //string rewardId32 = "75daa27e-7afc-4ede-a6fb-ceb18bb8aa75";
            //string rewardId33 = "c933d638-a99c-48e1-b2cd-d74f6155bdaa";

            //DateTime dateMerchant3 = new DateTime(2017, 8, 19);
            //DateTime dateBonusProgram3 = new DateTime(2017, 9, 3);
            //DateTime dateMerchantPOS31 = new DateTime(2017, 8, 24);
            //DateTime dateMerchantPOS32 = new DateTime(2017, 8, 10);
            //DateTime dateMerchantPOS33 = new DateTime(2017, 8, 10);
            //DateTime dateReward31 = new DateTime(2017, 9, 1);
            //DateTime dateReward32 = new DateTime(2017, 8, 11);
            //DateTime dateReward33 = new DateTime(2017, 8, 12);

            //Merchant merchant3 = new Merchant()
            //{
            //    Id = new Guid(merchant3Id),
            //    X_CreatedDate = dateMerchant3,
            //    X_LastUpdateDate = dateMerchant3,
            //    MerchantPOSCodes = "[\"CODE31\", \"CODE32\", \"CODE33\"]",
            //    Name = "ZARA",
            //    Type = "Clothes Store",
            //    LogoId = new Guid(logo3Id)
            //};

            //BonusProgram bonusProgram3 = new BonusProgram()
            //{
            //    Id = new Guid(bonusProgram3Id),
            //    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In ultricies ac leo ut placerat. Cras a tortor tristique, ullamcorper libero fermentum, pretium ipsum. Suspendisse potenti. Donec tristique tincidunt ante non lobortis. ",
            //    Ratio = 10,
            //    BackgroundPictureId = new Guid(backgroundPicture3Id),
            //    PointsLifetime = 30,
            //    Merchant_Id = new Guid(merchant3Id),
            //    SpecialOfferTitle = "Duis aliquet elit ",
            //    SpecialOfferDescription = " Etiam sagittis pretium felis, vel dignissim elit tempor sed. Nulla facilisi. Sed non fermentum metus, in vestibulum dui. Nam porta nec felis quis lobortis.",
            //    X_CreatedDate = dateBonusProgram3,
            //    X_LastUpdateDate = dateBonusProgram3,
            //    IsActive = true,
            //    ActivationDate = dateBonusProgram3
            //};

            //Reward reward31 = new Reward()
            //{
            //    Id = new Guid(rewardId31),
            //    Description = "In hac habitasse platea dictumst. Mauris scelerisque porttitor tincidunt. Mauris et malesuada dolor.",
            //    NeededPoints = 3000,
            //    Type = Enums.RewardType.GOLD,
            //    BonusProgram_Id = new Guid(bonusProgram3Id),
            //    X_CreatedDate = dateReward31,
            //    X_LastUpdateDate = dateReward31,
            //    Title = "Eget luctus justo malesuada"
            //};

            //Reward reward32 = new Reward()
            //{
            //    Id = new Guid(rewardId32),
            //    Description = "Sed sagittis diam augue, eget vulputate lectus varius tempus. Proin iaculis elit at tortor tincidunt ultrices.",
            //    NeededPoints = 2000,
            //    Type = Enums.RewardType.SILVER,
            //    BonusProgram_Id = new Guid(bonusProgram3Id),
            //    X_CreatedDate = dateReward32,
            //    X_LastUpdateDate = dateReward32,
            //    Title = "Mauris eget lectus"
            //};

            //Reward reward33 = new Reward()
            //{
            //    Id = new Guid(rewardId33),
            //    Description = "Sed ex lorem, dapibus ac egestas sit amet, consectetur pellentesque urna. Aenean porttitor, arcu quis maximus ornare,",
            //    NeededPoints = 1000,
            //    Type = Enums.RewardType.BRONZE,
            //    BonusProgram_Id = new Guid(bonusProgram3Id),
            //    X_CreatedDate = dateReward33,
            //    X_LastUpdateDate = dateReward33,
            //    Title = "Sed pharetra"
            //};

            //MerchantPOS merchantPOS31 = new MerchantPOS()
            //{
            //    Id = new Guid(merchantPOS31Id),
            //    Merchant_Id = new Guid(merchant3Id),
            //    NotificationName = "CODE31",
            //    City = "Wroc³aw",
            //    Street = "Kamienna",
            //    PostalCode = "90-359",
            //    Lat = 51.090120,
            //    Lon = 17.018561,
            //    X_CreatedDate = dateMerchantPOS31,
            //    X_LastUpdateDate = dateMerchantPOS31,
            //};

            //MerchantPOS merchantPOS32 = new MerchantPOS()
            //{
            //    Id = new Guid(merchantPOS32Id),
            //    Merchant_Id = new Guid(merchant3Id),
            //    NotificationName = "CODE32",
            //    City = "£ask",
            //    Street = "Narutowicza",
            //    PostalCode = "90-359",
            //    Lat = 51.588747,
            //    Lon = 19.132461,
            //    X_CreatedDate = dateMerchantPOS32,
            //    X_LastUpdateDate = dateMerchantPOS32,
            //};

            //MerchantPOS merchantPOS33 = new MerchantPOS()
            //{
            //    Id = new Guid(merchantPOS33Id),
            //    Merchant_Id = new Guid(merchant3Id),
            //    NotificationName = "CODE33",
            //    City = "Wroc³aw",
            //    Street = "POW",
            //    PostalCode = "90-359",
            //    Lat = 51.101162,
            //    Lon = 17.029131,
            //    X_CreatedDate = dateMerchantPOS33,
            //    X_LastUpdateDate = dateMerchantPOS33,
            //};

            //context.Merchants.AddOrUpdate(x => x.Id, merchant3);
            //context.BonusPrograms.AddOrUpdate(x => x.Id, bonusProgram3);
            //context.Rewards.AddOrUpdate(x => x.Id, reward31);
            //context.Rewards.AddOrUpdate(x => x.Id, reward32);
            //context.Rewards.AddOrUpdate(x => x.Id, reward33);
            //context.MerchantPOSes.AddOrUpdate(x => x.Id, merchantPOS31);
            //context.MerchantPOSes.AddOrUpdate(x => x.Id, merchantPOS32);
            //context.MerchantPOSes.AddOrUpdate(x => x.Id, merchantPOS33);


            //#endregion


            //#region #### Merchant 4 - Shell ####


            //string merchant4Id = "3bfa1f12-ee76-4c58-97ad-7cfdaf6c951d";
            //string logo4Id = "76b0d8b8-bf7d-4b58-b05a-224dedc4192b";
            //string bonusProgram4Id = "3b9eee45-ac4b-4112-b4f8-435d4acdfd70";
            //string backgroundPicture4Id = "616fc8a9-2e09-4d5d-9b7b-3e2635fe041a";
            //string merchantPOS41Id = "77e3944b-2ef4-4c01-a2ec-b09d1984dc94";

            //string rewardId41 = "86b57ce2-c46b-44a3-8511-835343345c72";
            //string rewardId42 = "80b3a540-62aa-4c2c-a133-f8d2dd131123";
            //string rewardId43 = "29fd07a1-82d9-460d-8b1e-d5130f088457";

            //DateTime dateMerchant4 = new DateTime(2017, 7, 12);
            //DateTime dateBonusProgram4 = new DateTime(2017, 9, 5);
            //DateTime dateMerchantPOS41 = new DateTime(2017, 8, 3);
            //DateTime dateReward41 = new DateTime(2017, 9, 2);
            //DateTime dateReward42 = new DateTime(2017, 8, 10);
            //DateTime dateReward43 = new DateTime(2017, 8, 17);

            //Merchant merchant4 = new Merchant()
            //{
            //    Id = new Guid(merchant4Id),
            //    X_CreatedDate = dateMerchant4,
            //    X_LastUpdateDate = dateMerchant4,
            //    MerchantPOSCodes = "[\"CODE41\"]",
            //    Name = "Shell",
            //    Type = "Gas Station",
            //    LogoId = new Guid(logo4Id)
            //};

            //BonusProgram bonusProgram4 = new BonusProgram()
            //{
            //    Id = new Guid(bonusProgram4Id),
            //    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In ultricies ac leo ut placerat. Cras a tortor tristique, ullamcorper libero fermentum, ",
            //    Ratio = 10,
            //    BackgroundPictureId = new Guid(backgroundPicture4Id),
            //    PointsLifetime = 30,
            //    IsActive = true,
            //    ActivationDate = dateBonusProgram4,
            //    Merchant_Id = new Guid(merchant4Id),
            //    SpecialOfferTitle = "Nullam gravida",
            //    SpecialOfferDescription = " Etiam sagittis pretium felis, vel dignissim elit tempor sed",
            //    X_CreatedDate = dateBonusProgram4,
            //    X_LastUpdateDate = dateBonusProgram4
            //};

            //Reward reward41 = new Reward()
            //{
            //    Id = new Guid(rewardId41),
            //    Description = "In hac habitasse platea dictumst. Mauris scelerisque porttitor tincidunt. Mauris et malesuada dolor.",
            //    NeededPoints = 3000,
            //    Type = Enums.RewardType.GOLD,
            //    BonusProgram_Id = new Guid(bonusProgram4Id),
            //    X_CreatedDate = dateReward41,
            //    X_LastUpdateDate = dateReward41,
            //    Title = "Proin cursus turpis"
            //};

            //Reward reward42 = new Reward()
            //{
            //    Id = new Guid(rewardId42),
            //    Description = "Sed sagittis diam augue, eget vulputate lectus varius tempus. Proin iaculis elit at tortor tincidunt ultrices.",
            //    NeededPoints = 2000,
            //    Type = Enums.RewardType.SILVER,
            //    BonusProgram_Id = new Guid(bonusProgram4Id),
            //    X_CreatedDate = dateReward42,
            //    X_LastUpdateDate = dateReward42,
            //    Title = "Duis aliquet elit"
            //};

            //Reward reward43 = new Reward()
            //{
            //    Id = new Guid(rewardId43),
            //    Description = "Sed ex lorem, dapibus ac egestas sit amet, consectetur pellentesque urna. Aenean porttitor, arcu quis maximus ornare,",
            //    NeededPoints = 1000,
            //    Type = Enums.RewardType.BRONZE,
            //    BonusProgram_Id = new Guid(bonusProgram4Id),
            //    X_CreatedDate = dateReward43,
            //    X_LastUpdateDate = dateReward43,
            //    Title = "Vivamus gravida"
            //};

            //MerchantPOS merchantPOS41 = new MerchantPOS()
            //{
            //    Id = new Guid(merchantPOS41Id),
            //    Merchant_Id = new Guid(merchant4Id),
            //    NotificationName = "CODE41",
            //    City = "Wroc³aw",
            //    Street = "Legnicka",
            //    PostalCode = "90-359",
            //    Lat = 51.115005,
            //    Lon = 17.002115,
            //    X_CreatedDate = dateMerchantPOS41,
            //    X_LastUpdateDate = dateMerchantPOS41,
            //};

            //context.Merchants.AddOrUpdate(x => x.Id, merchant4);
            //context.BonusPrograms.AddOrUpdate(x => x.Id, bonusProgram4);
            //context.Rewards.AddOrUpdate(x => x.Id, reward41);
            //context.Rewards.AddOrUpdate(x => x.Id, reward42);
            //context.Rewards.AddOrUpdate(x => x.Id, reward43);
            //context.MerchantPOSes.AddOrUpdate(x => x.Id, merchantPOS41);


            //#endregion


            //#region #### Merchant 5 - Leroy Merlin ####

            //string merchant5Id = "2bdc3549-febd-4925-89a8-01719330e0e8";
            //string logo5Id = "4bf7e4f6-4eb9-4a96-b501-3bfc5febf0a5";
            //string bonusProgram5Id = "f222be14-1427-451c-ad63-a5147f230d27";
            //string backgroundPicture5Id = "70b0b250-3a10-477e-b699-752e00f5a5de";
            //string merchantPOS51Id = "e992042d-735b-42e7-899a-697bcef1c607";
            //string merchantPOS52Id = "d7c54db7-5c03-40b3-9a2d-68663914a58d";

            //string rewardId51 = "2dff7f3b-37c9-449e-843f-6358bf00d345";
            //string rewardId52 = "ec10dc4f-e23f-497a-85df-a15933f80558";
            //string rewardId53 = "db0571fa-b47a-4b2a-964b-f7275ee078ea";

            //DateTime dateMerchant5 = new DateTime(2017, 7, 12);
            //DateTime dateBonusProgram5 = new DateTime(2017, 9, 3);
            //DateTime dateMerchantPOS51 = new DateTime(2017, 8, 5);
            //DateTime dateMerchantPOS52 = new DateTime(2017, 8, 12);
            //DateTime dateReward51 = new DateTime(2017, 9, 3);
            //DateTime dateReward52 = new DateTime(2017, 9, 3);
            //DateTime dateReward53 = new DateTime(2017, 8, 17);

            //Merchant merchant5 = new Merchant()
            //{
            //    Id = new Guid(merchant5Id),
            //    X_CreatedDate = dateMerchant5,
            //    X_LastUpdateDate = dateMerchant5,
            //    MerchantPOSCodes = "[\"CODE51\", \"CODE52\"]",
            //    Name = "Leroy Merlin",
            //    Type = "Construction shop",
            //    LogoId = new Guid(logo5Id)
            //};

            //BonusProgram bonusProgram5 = new BonusProgram()
            //{
            //    Id = new Guid(bonusProgram5Id),
            //    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In ultricies ac leo ut placerat. Cras a tortor tristique, ullamcorper libero fermentum, ",
            //    Ratio = 10,
            //    BackgroundPictureId = new Guid(backgroundPicture5Id),
            //    PointsLifetime = 10,
            //    IsActive = true,
            //    ActivationDate = dateBonusProgram5,
            //    Merchant_Id = new Guid(merchant5Id),
            //    SpecialOfferTitle = "Nullam gravida",
            //    SpecialOfferDescription = " Etiam sagittis pretium felis, vel dignissim elit tempor sed",
            //    X_CreatedDate = dateBonusProgram5,
            //    X_LastUpdateDate = dateBonusProgram5
            //};

            //Reward reward51 = new Reward()
            //{
            //    Id = new Guid(rewardId51),
            //    Description = "In hac habitasse platea dictumst. Mauris scelerisque porttitor tincidunt. Mauris et malesuada dolor.",
            //    NeededPoints = 3000,
            //    Type = Enums.RewardType.GOLD,
            //    BonusProgram_Id = new Guid(bonusProgram5Id),
            //    X_CreatedDate = dateReward51,
            //    X_LastUpdateDate = dateReward51,
            //    Title = "Proin cursus turpis"
            //};

            //Reward reward52 = new Reward()
            //{
            //    Id = new Guid(rewardId52),
            //    Description = "Sed sagittis diam augue, eget vulputate lectus varius tempus. Proin iaculis elit at tortor tincidunt ultrices.",
            //    NeededPoints = 1500,
            //    Type = Enums.RewardType.SILVER,
            //    BonusProgram_Id = new Guid(bonusProgram5Id),
            //    X_CreatedDate = dateReward52,
            //    X_LastUpdateDate = dateReward52,
            //    Title = "Duis aliquet elit"
            //};

            //Reward reward53 = new Reward()
            //{
            //    Id = new Guid(rewardId53),
            //    Description = "Sed ex lorem, dapibus ac egestas sit amet, consectetur pellentesque urna. Aenean porttitor, arcu quis maximus ornare,",
            //    NeededPoints = 500,
            //    Type = Enums.RewardType.BRONZE,
            //    BonusProgram_Id = new Guid(bonusProgram5Id),
            //    X_CreatedDate = dateReward53,
            //    X_LastUpdateDate = dateReward53,
            //    Title = "Vivamus gravida"
            //};

            //MerchantPOS merchantPOS51 = new MerchantPOS()
            //{
            //    Id = new Guid(merchantPOS51Id),
            //    Merchant_Id = new Guid(merchant5Id),
            //    NotificationName = "CODE51",
            //    City = "Warszawa",
            //    Street = "Legnicka",
            //    PostalCode = "90-359",
            //    Lat = 52.229394,
            //    Lon = 21.010767,
            //    X_CreatedDate = dateMerchantPOS51,
            //    X_LastUpdateDate = dateMerchantPOS51,
            //};

            //MerchantPOS merchantPOS52 = new MerchantPOS()
            //{
            //    Id = new Guid(merchantPOS52Id),
            //    Merchant_Id = new Guid(merchant5Id),
            //    NotificationName = "CODE52",
            //    City = "Zduñska Wola",
            //    Street = "Reymonta",
            //    PostalCode = "90-359",
            //    Lat = 51.587187,
            //    Lon = 18.923867,
            //    X_CreatedDate = dateMerchantPOS52,
            //    X_LastUpdateDate = dateMerchantPOS52,
            //};

            //context.Merchants.AddOrUpdate(x => x.Id, merchant5);
            //context.BonusPrograms.AddOrUpdate(x => x.Id, bonusProgram5);
            //context.Rewards.AddOrUpdate(x => x.Id, reward51);
            //context.Rewards.AddOrUpdate(x => x.Id, reward52);
            //context.Rewards.AddOrUpdate(x => x.Id, reward53);
            //context.MerchantPOSes.AddOrUpdate(x => x.Id, merchantPOS51);
            //context.MerchantPOSes.AddOrUpdate(x => x.Id, merchantPOS52);


            //#endregion


            //#region #### Merchant 6 - home & you ####


            //string merchant6Id = "d0c5b039-de6c-42f4-972c-7363bdb79bed";
            //string logo6Id = "e77d0649-36a6-427e-aa4b-cf40e0932e10";
            //string bonusProgram6Id = "eb26173c-cbf4-4958-8b6a-9c5152d82fc7";
            //string backgroundPicture6Id = "6d549437-fe52-4a7a-b407-09c75920cad3";
            //string merchantPOS61Id = "4c01e050-2f59-42a9-8ec6-f376e35e0f18";
            //string merchantPOS62Id = "4d356ab4-47c2-48a5-b818-260e0448ec72";

            //string rewardId61 = "eed00fff-574d-42fb-ae22-4bd0472fdd2d";
            //string rewardId62 = "33fa6bf6-ad3f-4ef9-b96e-4cfbb348f3d2";
            //string rewardId63 = "af5e2972-d5e2-4246-b03a-bedb9149e6f0";

            //DateTime dateMerchant6 = new DateTime(2017, 7, 12);
            //DateTime dateBonusProgram6 = new DateTime(2017, 9, 3);
            //DateTime dateMerchantPOS61 = new DateTime(2017, 8, 5);
            //DateTime dateMerchantPOS62 = new DateTime(2017, 8, 11);
            //DateTime dateReward61 = new DateTime(2017, 9, 3);
            //DateTime dateReward62 = new DateTime(2017, 9, 3);
            //DateTime dateReward63 = new DateTime(2017, 8, 17);

            //Merchant merchant6 = new Merchant()
            //{
            //    Id = new Guid(merchant6Id),
            //    X_CreatedDate = dateMerchant6,
            //    X_LastUpdateDate = dateMerchant6,
            //    MerchantPOSCodes = "[\"CODE61\", \"CODE62\"]",
            //    Name = "home & you",
            //    Type = "Store",
            //    LogoId = new Guid(logo6Id)
            //};

            //BonusProgram bonusProgram6 = new BonusProgram()
            //{
            //    Id = new Guid(bonusProgram6Id),
            //    Description = "Cras a tortor tristique, ullamcorper libero fermentum, ",
            //    Ratio = 10,
            //    BackgroundPictureId = new Guid(backgroundPicture6Id),
            //    PointsLifetime = 10,
            //    IsActive = true,
            //    ActivationDate = dateBonusProgram6,
            //    Merchant_Id = new Guid(merchant6Id),
            //    SpecialOfferTitle = "Nullam gravida",
            //    SpecialOfferDescription = " Vel dignissim elit tempor sed",
            //    X_CreatedDate = dateBonusProgram6,
            //    X_LastUpdateDate = dateBonusProgram6
            //};

            //Reward reward61 = new Reward()
            //{
            //    Id = new Guid(rewardId61),
            //    Description = "In hac porttitor tincidunt. Mauris et malesuada dolor.",
            //    NeededPoints = 3000,
            //    Type = Enums.RewardType.GOLD,
            //    BonusProgram_Id = new Guid(bonusProgram6Id),
            //    X_CreatedDate = dateReward61,
            //    X_LastUpdateDate = dateReward61,
            //    Title = "Proin turpis"
            //};

            //Reward reward62 = new Reward()
            //{
            //    Id = new Guid(rewardId62),
            //    Description = "Sed lectus varius tempus. Proin iaculis elit at tortor tincidunt ultrices.",
            //    NeededPoints = 1500,
            //    Type = Enums.RewardType.SILVER,
            //    BonusProgram_Id = new Guid(bonusProgram6Id),
            //    X_CreatedDate = dateReward62,
            //    X_LastUpdateDate = dateReward62,
            //    Title = "Duis elit"
            //};

            //Reward reward63 = new Reward()
            //{
            //    Id = new Guid(rewardId63),
            //    Description = "Sed ex lorem, dapibus ac egestas sit amet, Aenean porttitor, arcu quis maximus ornare,",
            //    NeededPoints = 500,
            //    Type = Enums.RewardType.BRONZE,
            //    BonusProgram_Id = new Guid(bonusProgram6Id),
            //    X_CreatedDate = dateReward63,
            //    X_LastUpdateDate = dateReward63,
            //    Title = "Vivamus gravida"
            //};

            //MerchantPOS merchantPOS61 = new MerchantPOS()
            //{
            //    Id = new Guid(merchantPOS61Id),
            //    Merchant_Id = new Guid(merchant6Id),
            //    NotificationName = "CODE61",
            //    City = "Warszawa",
            //    Street = "Legnicka",
            //    PostalCode = "90-359",
            //    Lat = 52.202417,
            //    Lon = 20.935347,
            //    X_CreatedDate = dateMerchantPOS61,
            //    X_LastUpdateDate = dateMerchantPOS61,
            //};

            //MerchantPOS merchantPOS62 = new MerchantPOS()
            //{
            //    Id = new Guid(merchantPOS62Id),
            //    Merchant_Id = new Guid(merchant6Id),
            //    NotificationName = "CODE62",
            //    City = "Kraków",
            //    Street = "Air Port Balice",
            //    PostalCode = "90-359",
            //    Lat = 50.079246,
            //    Lon = 19.787151,
            //    X_CreatedDate = dateMerchantPOS62,
            //    X_LastUpdateDate = dateMerchantPOS62,
            //};

            //context.Merchants.AddOrUpdate(x => x.Id, merchant6);
            //context.BonusPrograms.AddOrUpdate(x => x.Id, bonusProgram6);
            //context.Rewards.AddOrUpdate(x => x.Id, reward61);
            //context.Rewards.AddOrUpdate(x => x.Id, reward62);
            //context.Rewards.AddOrUpdate(x => x.Id, reward63);
            //context.MerchantPOSes.AddOrUpdate(x => x.Id, merchantPOS61);
            //context.MerchantPOSes.AddOrUpdate(x => x.Id, merchantPOS62);


            //#endregion


            //#region #### Merchant 7 - SUSHI BAR ####


            //string merchant7Id = "2c988fd0-e5b1-41f9-80b3-19e682463566";
            //string logo7Id = "5b4529b2-9020-4d37-8640-d7a9166c876f";
            //string bonusProgram7Id = "30859229-3354-452c-a6c8-69d326d4da86";
            //string backgroundPicture7Id = "c09c50f0-f672-4424-b8fb-8b324a8f30be";
            //string merchantPOSId71 = "d1e120c3-4c91-48d8-a380-80c64ec6e34d";
            //string merchantPOSId72 = "0676ba8a-ac62-4c79-8371-785b03cf0d2b";

            //string rewardId71 = "677f1c56-543b-43b2-ae71-0ae6c98b6bbe";
            //string rewardId72 = "8097ae94-a404-464e-ae07-bce33ab28923";
            //string rewardId73 = "2ccabfc8-1481-4aa3-a5de-c8a9c1201aaf";

            //DateTime dateMerchant7 = new DateTime(2017, 7, 12);
            //DateTime dateBonusProgram7 = new DateTime(2017, 9, 1);
            //DateTime dateMerchantPOS71 = new DateTime(2017, 8, 15);
            //DateTime dateMerchantPOS72 = new DateTime(2017, 8, 5);
            //DateTime dateReward71 = new DateTime(2017, 9, 1);
            //DateTime dateReward72 = new DateTime(2017, 9, 1);
            //DateTime dateReward73 = new DateTime(2017, 9, 1);


            //Merchant merchant7 = new Merchant()
            //{
            //    Id = new Guid(merchant7Id),
            //    X_CreatedDate = dateMerchant7,
            //    X_LastUpdateDate = dateMerchant7,
            //    MerchantPOSCodes = "[\"CODE71\", \"CODE72\"]",
            //    Name = "SUSHI BAR",
            //    Type = "Restaurant",
            //    LogoId = new Guid(logo7Id)
            //};

            //BonusProgram bonusProgram7 = new BonusProgram()
            //{
            //    Id = new Guid(bonusProgram7Id),
            //    Description = "Cras a tortor tristique, ullamcorper libero fermentum, ",
            //    Ratio = 10,
            //    BackgroundPictureId = new Guid(backgroundPicture7Id),
            //    PointsLifetime = 15,
            //    IsActive = true,
            //    ActivationDate = dateBonusProgram7,
            //    Merchant_Id = new Guid(merchant7Id),
            //    SpecialOfferTitle = "Nullam gravida",
            //    SpecialOfferDescription = " Vel dignissim elit tempor sed",
            //    X_CreatedDate = dateBonusProgram7,
            //    X_LastUpdateDate = dateBonusProgram7
            //};

            //Reward reward71 = new Reward()
            //{
            //    Id = new Guid(rewardId71),
            //    Description = "tincidunt. Mauris et malesuada dolor.",
            //    NeededPoints = 3000,
            //    Type = Enums.RewardType.GOLD,
            //    BonusProgram_Id = new Guid(bonusProgram7Id),
            //    X_CreatedDate = dateReward71,
            //    X_LastUpdateDate = dateReward71,
            //    Title = "Turpis"
            //};

            //Reward reward72 = new Reward()
            //{
            //    Id = new Guid(rewardId72),
            //    Description = "Sed lectus tincidunt ultrices.",
            //    NeededPoints = 1500,
            //    Type = Enums.RewardType.SILVER,
            //    BonusProgram_Id = new Guid(bonusProgram7Id),
            //    X_CreatedDate = dateReward72,
            //    X_LastUpdateDate = dateReward72,
            //    Title = "Duis elit"
            //};

            //Reward reward73 = new Reward()
            //{
            //    Id = new Guid(rewardId73),
            //    Description = "Aenean porttitor, arcu quis maximus ornare,",
            //    NeededPoints = 500,
            //    Type = Enums.RewardType.BRONZE,
            //    BonusProgram_Id = new Guid(bonusProgram7Id),
            //    X_CreatedDate = dateReward73,
            //    X_LastUpdateDate = dateReward73,
            //    Title = "Vivamus gravida"
            //};

            //MerchantPOS merchantPOS71 = new MerchantPOS()
            //{
            //    Id = new Guid(merchantPOSId71),
            //    Merchant_Id = new Guid(merchant7Id),
            //    NotificationName = "CODE71",
            //    City = "Tychy",
            //    Street = "Katowicka",
            //    PostalCode = "90-359",
            //    Lat = 50.120433,
            //    Lon = 19.024076,
            //    X_CreatedDate = dateMerchantPOS71,
            //    X_LastUpdateDate = dateMerchantPOS71,
            //};

            //MerchantPOS merchantPOS72 = new MerchantPOS()
            //{
            //    Id = new Guid(merchantPOSId72),
            //    Merchant_Id = new Guid(merchant7Id),
            //    NotificationName = "CODE72",
            //    City = "Pabianice",
            //    Street = "£aska",
            //    PostalCode = "90-359",
            //    Lat = 51.664834,
            //    Lon = 19.338019,
            //    X_CreatedDate = dateMerchantPOS72,
            //    X_LastUpdateDate = dateMerchantPOS72,
            //};

            //context.Merchants.AddOrUpdate(x => x.Id, merchant7);
            //context.BonusPrograms.AddOrUpdate(x => x.Id, bonusProgram7);
            //context.Rewards.AddOrUpdate(x => x.Id, reward71);
            //context.Rewards.AddOrUpdate(x => x.Id, reward72);
            //context.Rewards.AddOrUpdate(x => x.Id, reward73);
            //context.MerchantPOSes.AddOrUpdate(x => x.Id, merchantPOS71);
            //context.MerchantPOSes.AddOrUpdate(x => x.Id, merchantPOS72);


            //#endregion


            //#region #### Merchant 8 - Orlen ####


            //string merchant8Id = "66bb86f7-c58b-4d21-9d53-6c9e7d444cf4";
            //string logo8Id = "cb39082f-5aae-49ed-bff6-367ad769f48a";
            //string bonusProgram8Id = "1603ea86-2e09-41de-aabf-4161eb297cd2";
            //string backgroundPicture8Id = "93eee803-a31a-4853-9194-fb89e414afc6";
            //string merchantPOSId81 = "9d16cd19-02f6-4ef8-8ed9-441ae3fe84fa";
            //string merchantPOSId82 = "714c07fd-5e6c-474c-b676-b76347bfb550";
            //string merchantPOSId83 = "4f06ae43-1f27-4294-8e5b-4868e31eb59d";

            //string reward81Id = "47108a05-5424-4213-ab7f-0dce6bd34810";
            //string reward82Id = "72d3789c-19df-4997-aa1f-77755138972b";
            //string reward83Id = "3b6f5640-2bd8-4617-a6a7-153c07d4b15c";

            //DateTime dateMerchant8 = new DateTime(2017, 8, 15);
            //DateTime dateBonusProgram8 = new DateTime(2017, 9, 1);
            //DateTime dateMerchantPOS81 = new DateTime(2017, 8, 17);
            //DateTime dateMerchantPOS82 = new DateTime(2017, 8, 5);
            //DateTime dateMerchantPOS83 = new DateTime(2017, 8, 5);
            //DateTime dateReward81 = new DateTime(2017, 9, 1);
            //DateTime dateReward82 = new DateTime(2017, 9, 1);
            //DateTime dateReward83 = new DateTime(2017, 9, 1);


            //Merchant merchant8 = new Merchant()
            //{
            //    Id = new Guid(merchant8Id),
            //    X_CreatedDate = dateMerchant8,
            //    X_LastUpdateDate = dateMerchant8,
            //    MerchantPOSCodes = "[\"CODE81\", \"CODE82\", \"CODE83\", \"CODE84\", \"CODE85\"]",
            //    Name = "Orlen",
            //    Type = "Gas Station",
            //    LogoId = new Guid(logo8Id)
            //};

            //BonusProgram bonusProgram8 = new BonusProgram()
            //{
            //    Id = new Guid(bonusProgram8Id),
            //    Description = "tristique, ullamcorper libero fermentum, ",
            //    Ratio = 10,
            //    BackgroundPictureId = new Guid(backgroundPicture8Id),
            //    PointsLifetime = 18,
            //    IsActive = true,
            //    ActivationDate = dateBonusProgram8,
            //    Merchant_Id = new Guid(merchant8Id),
            //    SpecialOfferTitle = "Nullam gravida",
            //    SpecialOfferDescription = " Vel dignissim elit tempor sed",
            //    X_CreatedDate = dateBonusProgram8,
            //    X_LastUpdateDate = dateBonusProgram8
            //};

            //Reward reward81 = new Reward()
            //{
            //    Id = new Guid(reward81Id),
            //    Description = "tincidunt. Mauris et malesuada dolor.",
            //    NeededPoints = 3000,
            //    Type = Enums.RewardType.GOLD,
            //    BonusProgram_Id = new Guid(bonusProgram8Id),
            //    X_CreatedDate = dateReward81,
            //    X_LastUpdateDate = dateReward81,
            //    Title = "Turpis"
            //};

            //Reward reward82 = new Reward()
            //{
            //    Id = new Guid(reward82Id),
            //    Description = "Sed lectus tincidunt ultrices.",
            //    NeededPoints = 1500,
            //    Type = Enums.RewardType.SILVER,
            //    BonusProgram_Id = new Guid(bonusProgram8Id),
            //    X_CreatedDate = dateReward82,
            //    X_LastUpdateDate = dateReward82,
            //    Title = "Duis elit"
            //};

            //Reward reward83 = new Reward()
            //{
            //    Id = new Guid(reward83Id),
            //    Description = "Aenean porttitor, arcu quis maximus ornare,",
            //    NeededPoints = 500,
            //    Type = Enums.RewardType.BRONZE,
            //    BonusProgram_Id = new Guid(bonusProgram8Id),
            //    X_CreatedDate = dateReward83,
            //    X_LastUpdateDate = dateReward83,
            //    Title = "Vivamus gravida"
            //};

            //MerchantPOS merchantPOS81 = new MerchantPOS()
            //{
            //    Id = new Guid(merchantPOSId81),
            //    Merchant_Id = new Guid(merchant8Id),
            //    NotificationName = "CODE81",
            //    City = "Tychy",
            //    Street = "Katowicka",
            //    PostalCode = "90-359",
            //    Lat = 50.120433,
            //    Lon = 19.024076,
            //    X_CreatedDate = dateMerchantPOS81,
            //    X_LastUpdateDate = dateMerchantPOS81,
            //};

            //MerchantPOS merchantPOS82 = new MerchantPOS()
            //{
            //    Id = new Guid(merchantPOSId82),
            //    Merchant_Id = new Guid(merchant8Id),
            //    NotificationName = "CODE82",
            //    City = "Kraków",
            //    Street = "Air Port Balice",
            //    PostalCode = "90-359",
            //    Lat = 50.079246,
            //    Lon = 19.787151,
            //    X_CreatedDate = dateMerchantPOS82,
            //    X_LastUpdateDate = dateMerchantPOS82,
            //};

            //MerchantPOS merchantPOS83 = new MerchantPOS()
            //{
            //    Id = new Guid(merchantPOSId83),
            //    Merchant_Id = new Guid(merchant8Id),
            //    NotificationName = "CODE83",
            //    City = "Busko Zdrój",
            //    Street = "Miko³aja Kopernika",
            //    PostalCode = "90-359",
            //    Lat = 50.464617,
            //    Lon = 20.718812,
            //    X_CreatedDate = dateMerchantPOS83,
            //    X_LastUpdateDate = dateMerchantPOS83,
            //};

            //context.Merchants.AddOrUpdate(x => x.Id, merchant8);
            //context.BonusPrograms.AddOrUpdate(x => x.Id, bonusProgram8);
            //context.Rewards.AddOrUpdate(x => x.Id, reward81);
            //context.Rewards.AddOrUpdate(x => x.Id, reward82);
            //context.Rewards.AddOrUpdate(x => x.Id, reward83);
            //context.MerchantPOSes.AddOrUpdate(x => x.Id, merchantPOS81);
            //context.MerchantPOSes.AddOrUpdate(x => x.Id, merchantPOS82);
            //context.MerchantPOSes.AddOrUpdate(x => x.Id, merchantPOS83);


            //#endregion


            //#region #### Merchant 9 - TUI ####


            //string merchant9Id = "c8be15be-56bd-4c57-a829-026a16173f80";
            //string logo9Id = "17184194-034d-45f3-bb55-e2a99ce3fec5";
            //string bonusProgram9Id = "504a3cc7-ba39-4fcb-8abd-e6806d5a8fe5";
            //string backgroundPicture9Id = "a5070e74-d5c6-4d5e-8af5-7ae23e48e045";
            //string merchantPOSId91 = "2333f469-004f-44d4-92cb-c5ba528b4911";
            //string merchantPOSId92 = "1dd968a2-198c-4505-a672-8fa40cde5ee9";
            //string merchantPOSId93 = "eea87de8-e98b-4cb5-b030-4bd5e079c549";

            //string reward91Id = "1b22a196-f5e4-49f4-be85-d9ee74ca7d36";
            //string reward92Id = "07a0a74f-f415-4d70-a683-2c5cbaf06f13";
            //string reward93Id = "7d930620-e0c2-4d44-936a-446479494652";

            //DateTime dateMerchant9 = new DateTime(2017, 8, 15);
            //DateTime dateBonusProgram9 = new DateTime(2017, 9, 1);
            //DateTime dateMerchantPOS91 = new DateTime(2017, 8, 17);
            //DateTime dateMerchantPOS92 = new DateTime(2017, 8, 5);
            //DateTime dateMerchantPOS93 = new DateTime(2017, 8, 5);
            //DateTime dateReward91 = new DateTime(2017, 9, 1);
            //DateTime dateReward92 = new DateTime(2017, 9, 1);
            //DateTime dateReward93 = new DateTime(2017, 9, 1);


            //Merchant merchant9 = new Merchant()
            //{
            //    Id = new Guid(merchant9Id),
            //    X_CreatedDate = dateMerchant9,
            //    X_LastUpdateDate = dateMerchant9,
            //    MerchantPOSCodes = "[\"CODE91\", \"CODE92\"]",
            //    Name = "TUI",
            //    Type = "Travel agency",
            //    LogoId = new Guid(logo9Id)
            //};

            //BonusProgram bonusProgram9 = new BonusProgram()
            //{
            //    Id = new Guid(bonusProgram9Id),
            //    Description = "Bonus program remain a common element of the total rewards package offered to most employees.This is expected, as more and more employers look to differentiate rewards based on performance and build in flexibility to focus budget dollars where they are most needed.It appears, however, that bonus programs are utilized more to attract talent rather than to retain it — sign - on and referral bonuses are more common than spot and retention bonuses",
            //    Ratio = 5,
            //    BackgroundPictureId = new Guid(backgroundPicture9Id),
            //    PointsLifetime = 30,
            //    IsActive = true,
            //    ActivationDate = dateBonusProgram9,
            //    Merchant_Id = new Guid(merchant9Id),
            //    SpecialOfferTitle = "Last minute",
            //    SpecialOfferDescription = "Jamaica’s bubbly side is on show in Montego Bay. This lively north-coast town has a strip full of reggae bars and Caribbean restaurants, and you can dip in and out for rum cocktails and jerk chicken. Montego Bay’s biggest pull, though, is its coastline. The shores here are bracketed by clear blue waves and coconut palms.",
            //    X_CreatedDate = dateBonusProgram9,
            //    X_LastUpdateDate = dateBonusProgram9,
            //    BackgroundPictureStatus = Enums.BlobUploadStatus.UPLOADED
            //};

            //Reward reward91 = new Reward()
            //{
            //    Id = new Guid(reward91Id),
            //    Description = "Glittering sands that disappear into the distance.Souks brimming with sparkling trinkets.Medinas that ring with snake - charmers’ melodies.Morocco is a spice - scented corner of the world that thrills the senses.",
            //    NeededPoints = 5000,
            //    Type = Enums.RewardType.GOLD,
            //    BonusProgram_Id = new Guid(bonusProgram9Id),
            //    X_CreatedDate = dateReward91,
            //    X_LastUpdateDate = dateReward91,
            //    Title = "AGADIR, MOROCCO"
            //};

            //Reward reward92 = new Reward()
            //{
            //    Id = new Guid(reward92Id),
            //    Description = "Spread out across 14 islands, spotless Stockholm is an enchanting slice of Scandinavia.Bursting with museums, galleries, bars and restaurants, there’s never a dull moment in this spellbinding city.• Explore the quaint cobbled streets of the old town and stumble upon the splendid Royal Palace, surrounded by grand houses and elegant boutiques.",
            //    NeededPoints = 3000,
            //    Type = Enums.RewardType.SILVER,
            //    BonusProgram_Id = new Guid(bonusProgram9Id),
            //    X_CreatedDate = dateReward92,
            //    X_LastUpdateDate = dateReward92,
            //    Title = "STOCKHOLM, SWEDEN"
            //};

            //Reward reward93 = new Reward()
            //{
            //    Id = new Guid(reward93Id),
            //    Description = "Bergen is famous for being the birthplace of the great Norwegian composer, Edvard Grieg.With its brightly - coloured houses and maze - like cobbled streets, one thing’s for sure, this city was made for strolling.• Don’t miss one of Bergen’s main attractions, Troldhaugen, Grieg’s home.Beautifully set on Lake Nordaas, the Swiss - style house was built back in 1885.",
            //    NeededPoints = 1000,
            //    Type = Enums.RewardType.BRONZE,
            //    BonusProgram_Id = new Guid(bonusProgram9Id),
            //    X_CreatedDate = dateReward93,
            //    X_LastUpdateDate = dateReward93,
            //    Title = "BERGEN, NORWAY"
            //};

            //MerchantPOS merchantPOS91 = new MerchantPOS()
            //{
            //    Id = new Guid(merchantPOSId91),
            //    Merchant_Id = new Guid(merchant9Id),
            //    NotificationName = "CODE91",
            //    City = "Tychy",
            //    Street = "Katowicka",
            //    PostalCode = "90-359",
            //    Lat = 50.120433,
            //    Lon = 19.024076,
            //    X_CreatedDate = dateMerchantPOS91,
            //    X_LastUpdateDate = dateMerchantPOS91,
            //};

            //MerchantPOS merchantPOS92 = new MerchantPOS()
            //{
            //    Id = new Guid(merchantPOSId92),
            //    Merchant_Id = new Guid(merchant9Id),
            //    NotificationName = "CODE92",
            //    City = "Kraków",
            //    Street = "Air Port Balice",
            //    PostalCode = "90-359",
            //    Lat = 50.079246,
            //    Lon = 19.787151,
            //    X_CreatedDate = dateMerchantPOS92,
            //    X_LastUpdateDate = dateMerchantPOS92,
            //};

            //MerchantPOS merchantPOS93 = new MerchantPOS()
            //{
            //    Id = new Guid(merchantPOSId93),
            //    Merchant_Id = new Guid(merchant9Id),
            //    NotificationName = "CODE93",
            //    City = "Busko Zdrój",
            //    Street = "Miko³aja Kopernika",
            //    PostalCode = "90-359",
            //    Lat = 50.464617,
            //    Lon = 20.718812,
            //    X_CreatedDate = dateMerchantPOS93,
            //    X_LastUpdateDate = dateMerchantPOS93,
            //};

            //context.Merchants.AddOrUpdate(x => x.Id, merchant9);
            //context.BonusPrograms.AddOrUpdate(x => x.Id, bonusProgram9);
            //context.Rewards.AddOrUpdate(x => x.Id, reward91);
            //context.Rewards.AddOrUpdate(x => x.Id, reward92);
            //context.Rewards.AddOrUpdate(x => x.Id, reward93);
            //context.MerchantPOSes.AddOrUpdate(x => x.Id, merchantPOS91);
            //context.MerchantPOSes.AddOrUpdate(x => x.Id, merchantPOS92);
            //context.MerchantPOSes.AddOrUpdate(x => x.Id, merchantPOS93);
            //#endregion


            //#region #### Merchant 10 - Statoil ####


            //string merchant10Id = "6f8c8f81-a3c7-4c7a-a0fc-82e858c56bb2";
            //string logo10Id = "65558604-154f-4fce-b4ee-cd5eb27b2ca3";
            //string bonusProgram10Id = "a2b117fb-9e2f-4fb1-8605-f52e0944a704";
            //string backgroundPicture10Id = "aab4931a-fd8e-4101-8c4c-e3c52d9f899b";
            //string merchantPOSId101 = "b28da5da-2479-40b4-87d7-10b8674629f8";
            //string merchantPOSId102 = "3f3ba5ff-d027-4717-a1b9-183147600a0c";
            //string merchantPOSId103 = "cb46701e-513a-4530-b3f4-6ee05bb3572c";

            //string reward101Id = "b6928f2f-874e-4285-b26f-97f4451089e0";
            //string reward102Id = "35f9e5c2-8932-420b-b9ec-18588a0f01c5";
            //string reward103Id = "c1e06ec9-5735-45cc-b9b4-a36af207eaa7";

            //DateTime dateMerchant10 = new DateTime(2017, 8, 15);
            //DateTime dateBonusProgram10 = new DateTime(2017, 9, 1);
            //DateTime dateMerchantPOS101 = new DateTime(2017, 8, 17);
            //DateTime dateMerchantPOS102 = new DateTime(2017, 8, 5);
            //DateTime dateMerchantPOS103 = new DateTime(2017, 8, 5);
            //DateTime dateReward101 = new DateTime(2017, 9, 1);
            //DateTime dateReward102 = new DateTime(2017, 9, 1);
            //DateTime dateReward103 = new DateTime(2017, 9, 1);


            //Merchant merchant10 = new Merchant()
            //{
            //    Id = new Guid(merchant10Id),
            //    X_CreatedDate = dateMerchant10,
            //    X_LastUpdateDate = dateMerchant10,
            //    MerchantPOSCodes = "[\"CODE101\", \"CODE102\"]",
            //    Name = "Statoil",
            //    Type = "Gas Station",
            //    LogoId = new Guid(logo10Id)
            //};

            //BonusProgram bonusProgram10 = new BonusProgram()
            //{
            //    Id = new Guid(bonusProgram10Id),
            //    Description = "Statoil is an innovative company open to challenges. We focus on connecting with institutions and companies large and small that can help us find solutions to concrete business challenges. We know that we’ll need to keep pushing the boundaries to achieve our goals—and we want to do it with you. You can join to bouns program to get more benefits",
            //    Ratio = 3,
            //    BackgroundPictureId = new Guid(backgroundPicture10Id),
            //    PointsLifetime = 18,
            //    IsActive = true,
            //    ActivationDate = dateBonusProgram10,
            //    Merchant_Id = new Guid(merchant10Id),
            //    SpecialOfferTitle = "Arctic fuel",
            //    SpecialOfferDescription = "Now you can refuel with arctic fuel only in statoil. The Arctic DieselGold composition is designed to provide extreme low temperature properties. By lowering the cloud temperature and the Cold Start Filter Temperatures (CFPP), starting a vehicle powered by this fuel will be possible even at temperatures below -32 ° C.",
            //    X_CreatedDate = dateBonusProgram10,
            //    X_LastUpdateDate = dateBonusProgram10,
            //    BackgroundPictureStatus = Enums.BlobUploadStatus.UPLOADED
            //};

            //Reward reward101 = new Reward()
            //{
            //    Id = new Guid(reward101Id),
            //    Description = "100 liters SupraDiesel, SupraGaz, Suprema 98, EuroSuper 95 for free at each gas station of our company",
            //    NeededPoints = 4000,
            //    Type = Enums.RewardType.GOLD,
            //    BonusProgram_Id = new Guid(bonusProgram10Id),
            //    X_CreatedDate = dateReward101,
            //    X_LastUpdateDate = dateReward101,
            //    Title = "100 liters of fuel"
            //};

            //Reward reward102 = new Reward()
            //{
            //    Id = new Guid(reward102Id),
            //    Description = "Water can also be collected in the fuel filter. This poses a threat to the functioning of the fuel system whenever the temperature drops below 0 ° C. Frost water limits fuel flow, which can cause engine malfunctions and even immobilisation. To prevent such situations it is best to replace the fuel filter with a new one before winter. We will do it for you for free",
            //    NeededPoints = 2500,
            //    Type = Enums.RewardType.SILVER,
            //    BonusProgram_Id = new Guid(bonusProgram10Id),
            //    X_CreatedDate = dateReward102,
            //    X_LastUpdateDate = dateReward102,
            //    Title = "Replace the fuel filter"
            //};

            //Reward reward103 = new Reward()
            //{
            //    Id = new Guid(reward103Id),
            //    Description = "At our gas stations you will get free windscreen washer fluid in the car of the highest technology. The liquid does not freeze even at -52 ° C.",
            //    NeededPoints = 1000,
            //    Type = Enums.RewardType.BRONZE,
            //    BonusProgram_Id = new Guid(bonusProgram10Id),
            //    X_CreatedDate = dateReward103,
            //    X_LastUpdateDate = dateReward103,
            //    Title = "Replacement windscreen washer fluid"
            //};

            //MerchantPOS merchantPOS101 = new MerchantPOS()
            //{
            //    Id = new Guid(merchantPOSId101),
            //    Merchant_Id = new Guid(merchant10Id),
            //    NotificationName = "CODE101",
            //    City = "Tychy",
            //    Street = "Katowicka",
            //    PostalCode = "90-359",
            //    Lat = 50.120433,
            //    Lon = 19.024076,
            //    X_CreatedDate = dateMerchantPOS101,
            //    X_LastUpdateDate = dateMerchantPOS101,
            //};

            //MerchantPOS merchantPOS102 = new MerchantPOS()
            //{
            //    Id = new Guid(merchantPOSId102),
            //    Merchant_Id = new Guid(merchant10Id),
            //    NotificationName = "CODE102",
            //    City = "Kraków",
            //    Street = "Air Port Balice",
            //    PostalCode = "90-359",
            //    Lat = 50.079246,
            //    Lon = 19.787151,
            //    X_CreatedDate = dateMerchantPOS102,
            //    X_LastUpdateDate = dateMerchantPOS102,
            //};


            //context.Merchants.AddOrUpdate(x => x.Id, merchant10);
            //context.BonusPrograms.AddOrUpdate(x => x.Id, bonusProgram10);
            //context.Rewards.AddOrUpdate(x => x.Id, reward101);
            //context.Rewards.AddOrUpdate(x => x.Id, reward102);
            //context.Rewards.AddOrUpdate(x => x.Id, reward103);
            //context.MerchantPOSes.AddOrUpdate(x => x.Id, merchantPOS101);
            //context.MerchantPOSes.AddOrUpdate(x => x.Id, merchantPOS102);

            //#endregion


            //#region #### Merchant 11 - InAzia ####


            //string merchant11Id = "174469df-e9fb-4d58-9fa4-549f28404fc2";
            //string logo11Id = "f7b1bb8b-a759-4dc2-9d8e-bfbf5bb2a7f0";
            //string bonusProgram11Id = "8c049825-1f9c-4a3c-8c32-0aebf3f699aa";
            //string backgroundPicture11Id = "11f6e7d9-e827-4ca8-96ea-66c1e212bb13";
            //string merchantPOSId111 = "ee324c43-7d9e-44df-bfda-13b7795301cb";

            //string reward111Id = "9fe42313-4c8a-43cb-8604-d4ff71c4ebd1";
            //string reward112Id = "b24c3ab4-e6d5-4575-b460-0522d8fe186d";
            //string reward113Id = "1c33a248-1f48-433c-b8ff-0b9b1e8e6866";

            //DateTime dateMerchant11 = new DateTime(2017, 8, 15);
            //DateTime dateBonusProgram11 = new DateTime(2017, 9, 1);
            //DateTime dateMerchantPOS111 = new DateTime(2017, 8, 17);
            //DateTime dateMerchantPOS112 = new DateTime(2017, 8, 5);
            //DateTime dateMerchantPOS113 = new DateTime(2017, 8, 5);
            //DateTime dateReward111 = new DateTime(2017, 9, 1);
            //DateTime dateReward112 = new DateTime(2017, 9, 1);
            //DateTime dateReward113 = new DateTime(2017, 9, 1);


            //Merchant merchant11 = new Merchant()
            //{
            //    Id = new Guid(merchant11Id),
            //    X_CreatedDate = dateMerchant11,
            //    X_LastUpdateDate = dateMerchant11,
            //    MerchantPOSCodes = "[\"CODE111\", \"CODE112\"]",
            //    Name = "InAzia",
            //    Type = "Restaurant",
            //    LogoId = new Guid(logo11Id)
            //};

            //BonusProgram bonusProgram11 = new BonusProgram()
            //{
            //    Id = new Guid(bonusProgram11Id),
            //    Description = "InAzia restaurant at the Sheraton Warsaw Hotel was launched to continue the culinary journey through the world of Asian flavours and aromas initiated by the well-recognised and highly awarded The Oriental Restaurant. InAzia offers a unique, rich and personalised culinary experience combined with contemporary Asian interiors and spectacular modern cuisine",
            //    Ratio = 15,
            //    BackgroundPictureId = new Guid(backgroundPicture11Id),
            //    PointsLifetime = 40,
            //    IsActive = true,
            //    ActivationDate = dateBonusProgram11,
            //    Merchant_Id = new Guid(merchant11Id),
            //    SpecialOfferTitle = "Sunday Brunch at inAzia",
            //    SpecialOfferDescription = "Every Sunday between 12:30 and 4:30 pm we invite you to for an Asian style buffet with cold starters, steaming hot dishes, fish & seafood dishes and irresistible desserts. For our younger guests we offer a special selection of children's favorites and kid's playground is available.",
            //    X_CreatedDate = dateBonusProgram11,
            //    X_LastUpdateDate = dateBonusProgram11,
            //    BackgroundPictureStatus = Enums.BlobUploadStatus.UPLOADED
            //};

            //Reward reward111 = new Reward()
            //{
            //    Id = new Guid(reward111Id),
            //    Description = "A traditional spicy Thai soup with chicken and coconut milk, it is one of the most popular dishes in our restaurant. The soup's spicy flavour is gently soothed by the coconut milk. Tom Kha Gai is light and refreshing and every Far East cuisine lover will find his/her favourite flavours in it.",
            //    NeededPoints = 4000,
            //    Type = Enums.RewardType.GOLD,
            //    BonusProgram_Id = new Guid(bonusProgram11Id),
            //    X_CreatedDate = dateReward111,
            //    X_LastUpdateDate = dateReward111,
            //    Title = "TOM KHA GAI"
            //};

            //Reward reward112 = new Reward()
            //{
            //    Id = new Guid(reward112Id),
            //    Description = "With green vegetables and hoi sin and sweet chilli sauces. Peking duck is one of the flagship Chinese dishes at InAzia restaurant; but here we have gone several steps further - we recommend the crispy duck, sliced, with the hoi sin's sweet-spicy taste.",
            //    NeededPoints = 2500,
            //    Type = Enums.RewardType.SILVER,
            //    BonusProgram_Id = new Guid(bonusProgram11Id),
            //    X_CreatedDate = dateReward112,
            //    X_LastUpdateDate = dateReward112,
            //    Title = "CRISPY DUCK"
            //};

            //Reward reward113 = new Reward()
            //{
            //    Id = new Guid(reward113Id),
            //    Description = "Thai fried noodles with shrimp and peanuts. In Thailand you can eat it anywhere; at stalls, in the street and on almost every street corner. Due to its popularity it appears in many options, often with meat: chicken or pork, or as a vegetarian dish.",
            //    NeededPoints = 1000,
            //    Type = Enums.RewardType.BRONZE,
            //    BonusProgram_Id = new Guid(bonusProgram11Id),
            //    X_CreatedDate = dateReward113,
            //    X_LastUpdateDate = dateReward113,
            //    Title = "PAD THAI"
            //};

            //MerchantPOS merchantPOS111 = new MerchantPOS()
            //{
            //    Id = new Guid(merchantPOSId111),
            //    Merchant_Id = new Guid(merchant11Id),
            //    NotificationName = "CODE111",
            //    City = "Warszawa",
            //    Street = "Aleja Niepodleg³oœci",
            //    PostalCode = "00-001",
            //    Lat = 52.206884,
            //    Lon = 21.008550,
            //    X_CreatedDate = dateMerchantPOS111,
            //    X_LastUpdateDate = dateMerchantPOS111,
            //};

            //context.Merchants.AddOrUpdate(x => x.Id, merchant11);
            //context.BonusPrograms.AddOrUpdate(x => x.Id, bonusProgram11);
            //context.Rewards.AddOrUpdate(x => x.Id, reward111);
            //context.Rewards.AddOrUpdate(x => x.Id, reward112);
            //context.Rewards.AddOrUpdate(x => x.Id, reward113);
            //context.MerchantPOSes.AddOrUpdate(x => x.Id, merchantPOS111);

            //#endregion

            //context.SaveChanges();


            //// #### Merchant <-> BonusProgram binding

            //merchant1.ActiveBonusProgram_Id = new Guid(bonusProgram1Id);
            //context.Merchants.AddOrUpdate(x => x.Id, merchant1);

            //merchant2.ActiveBonusProgram_Id = new Guid(bonusProgram2Id);
            //context.Merchants.AddOrUpdate(x => x.Id, merchant2);

            //merchant3.ActiveBonusProgram_Id = new Guid(bonusProgram3Id);
            //context.Merchants.AddOrUpdate(x => x.Id, merchant3);

            //merchant4.ActiveBonusProgram_Id = new Guid(bonusProgram4Id);
            //context.Merchants.AddOrUpdate(x => x.Id, merchant4);

            //merchant5.ActiveBonusProgram_Id = new Guid(bonusProgram5Id);
            //context.Merchants.AddOrUpdate(x => x.Id, merchant5);

            //merchant6.ActiveBonusProgram_Id = new Guid(bonusProgram6Id);
            //context.Merchants.AddOrUpdate(x => x.Id, merchant6);

            //merchant7.ActiveBonusProgram_Id = new Guid(bonusProgram7Id);
            //context.Merchants.AddOrUpdate(x => x.Id, merchant7);

            //merchant8.ActiveBonusProgram_Id = new Guid(bonusProgram8Id);
            //context.Merchants.AddOrUpdate(x => x.Id, merchant8);
        }

    }
}
