using System;
using Xunit;

namespace _929.UniqueEmailAddresses
{
    public class UniqueEmailAddressTest
    {
        [Fact]
        public void Should_Throw_An_Exception_When_Emails_Are_Null()
        {
            Assert.Throws(new ArgumentNullException().GetType(),
                          () => new UniqueEmailAddress().NumUniqueEmails(null));
        }

        [Fact]
        public void An_Empty_Email_List_Should_Return_Zero()
        {
            Assert.Equal(0, new UniqueEmailAddress().NumUniqueEmails(new string[] { }));
        }

        [Fact]
        public void Test_Case_Should_Return_One()
        {
            Assert.Equal(1, new UniqueEmailAddress().NumUniqueEmails(
                                new string[] { "test.email+alex@leetcode.com" }));
        }

        [Fact]
        public void Test_Case_2_Should_Return_Two()
        {
            Assert.Equal(2, new UniqueEmailAddress().NumUniqueEmails(
                                new string[] { "test.email+alex@google.com",
                                               "test.e.mail+bob.cathy@leetcode.com" }));
        }

        [Fact]
        public void Test_Case_3_Should_Return_Three()
        {
            Assert.Equal(2, new UniqueEmailAddress().NumUniqueEmails(
                                new string[] { "test.email+alex@leetcode.com",
                                               "test.e.mail+bob.cathy@leetcode.com",
                                               "testemail+david@lee.tcode.com" }));
        }
    }
}
