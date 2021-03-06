﻿using System.Collections.Generic;
using NUnit.Framework;

namespace wikia.integration.tests
{
    public static class WikiaTestData
    {
        public static IEnumerable<TestCaseData> ArticleIdTestUrlData
        {
            get
            {
                yield return new TestCaseData
                (
                    "http://yugioh.wikia.com",
                    300400 // Eclipse  Wyvern card page
                );
                yield return new TestCaseData
                (
                    "http://naruto.wikia.com/",
                    1612 // Rock character page
                );
                yield return new TestCaseData
                (
                    "http://elderscrolls.wikia.com/",
                    41277 // Orc page
                );
            }
        }

        public static IEnumerable<TestCaseData> SearchTestData
        {
            get
            {
                yield return new TestCaseData
                (
                    "http://yugioh.wikia.com",
                    "yugioh" // Eclipse  Wyvern card page
                );
                yield return new TestCaseData
                (
                    "http://naruto.wikia.com/",
                    "rock lee" // Rock character page
                );
                yield return new TestCaseData
                (
                    "http://elderscrolls.wikia.com/",
                    "Orc" // Orc page
                );
            }
        }

        public static IEnumerable<TestCaseData> ArticleCategoryTestData
        {
            get
            {
                yield return new TestCaseData
                (
                    "http://yugioh.wikia.com",
                    "Card_Tips" // yugioh tips category
                );
                yield return new TestCaseData
                (
                    "http://naruto.wikia.com/",
                    "Characters" // naruto characters
                );
                yield return new TestCaseData
                (
                    "http://elderscrolls.wikia.com/",
                    "Classes" // Skyrim classes
                );
            }
        }

        public static IEnumerable<TestCaseData> WikiUrlsTestData
        {
            get
            {
                yield return new TestCaseData
                (
                    "http://yugioh.wikia.com"
                );
                yield return new TestCaseData
                (
                    "http://naruto.wikia.com/"
                );
                yield return new TestCaseData
                (
                    "http://elderscrolls.wikia.com/"
                );
            }
        }

        public static IEnumerable<TestCaseData> UserTestData
        {
            get
            {
                yield return new TestCaseData
                (
                    "http://yugioh.wikia.com",
                    "166269" // user id
                );
                yield return new TestCaseData
                (
                    "http://naruto.wikia.com/",
                    "1236002" // User id
                );
                yield return new TestCaseData
                (
                    "http://elderscrolls.wikia.com/",
                    "32045548" // User id
                );
            }
        }

    }
}