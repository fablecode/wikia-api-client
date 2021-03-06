﻿using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using wikia.Api;
using wikia.Models.Article.Popular;

namespace wikia.integration.tests.WikiaArticleTests
{
    [TestFixture]
    public class PopularArticleTests
    {
        [TestCaseSource(typeof(WikiaTestData), nameof(WikiaTestData.WikiUrlsTestData))]
        public async Task Given_A_DomainUrl_Should_Successfully_Retrieve_Simple_Popular_Articles(string domainUrl)
        {
            // Arrange
            var sut = new WikiArticle(domainUrl);

            // Act
            var result = await sut.PopularArticleSimple(new PopularArticleRequestParameters());

            // Assert
            result.Should().NotBeNull();
        }

        [TestCaseSource(typeof(WikiaTestData), nameof(WikiaTestData.WikiUrlsTestData))]
        public async Task Given_A_DomainUrl_PopularExpandedArticleResultSet_Should_Contain_Atleast_1_Item(string domainUrl)
        {
            // Arrange
            var sut = new WikiArticle(domainUrl);

            // Act
            var result = await sut.PopularArticleDetail(new PopularArticleRequestParameters());

            // Assert
            result.Items.Should().NotBeEmpty();
        }
    }
}