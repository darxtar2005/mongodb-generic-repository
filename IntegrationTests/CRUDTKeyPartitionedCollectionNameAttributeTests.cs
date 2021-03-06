﻿using IntegrationTests.Infrastructure;
using MongoDbGenericRepository.Attributes;
using MongoDbGenericRepository.Models;
using System;

namespace IntegrationTests
{
    [CollectionName("TestingCollectionNameAttributePartitionedTKey")]
    public class TKeyPartitionedCollectionNameDoc : TestDoc<Guid>, IPartitionedDocument
    {
        public TKeyPartitionedCollectionNameDoc()
        {
            PartitionKey = "TestPartitionKey";
        }

        public string PartitionKey { get; set; }
    }

    public class CRUDTKeyPartitionedCollectionNameAttributeTests : MongoDbTKeyDocumentTestBase<TKeyPartitionedCollectionNameDoc, Guid>
    {
        public override string GetClassName()
        {
            return "CRUDTKeyPartitionedCollectionNameAttributeTests";
        }
    }
}
