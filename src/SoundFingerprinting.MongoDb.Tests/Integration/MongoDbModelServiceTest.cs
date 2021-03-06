﻿namespace SoundFingerprinting.MongoDb.Tests.Integration
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using SoundFingerprinting.MongoDb.Entity;
    using SoundFingerprinting.Tests.Integration;

    [TestClass]
    public class MongoDbModelServiceTest : ModelServiceTest
    {
        private readonly DaoTestHelper daoTestHelper = new DaoTestHelper();

        public MongoDbModelServiceTest()
        {
            ModelService = new MongoDbModelService();
        }

        public override sealed IModelService ModelService { get; set; }

        [TestInitialize]
        public void SetUp()
        {
            daoTestHelper.GetCollection<SubFingerprint>(SubFingerprintDao.SubFingerprints).RemoveAll();
            daoTestHelper.GetCollection<Track>(TrackDao.Tracks).RemoveAll();
            daoTestHelper.GetCollection<Hash>(HashBinDao.HashBins).RemoveAll();
            daoTestHelper.GetCollection<Fingerprint>(FingerprintDao.Fingerprints).RemoveAll();
        }
    }
}
