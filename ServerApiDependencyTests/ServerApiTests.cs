using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NSubstitute.ReturnsExtensions;
using ServerApiDependency.Enum;
using ServerApiDependency.Enums;
using ServerApiDependency.Utility.CustomException;

namespace ServerApiDependency.Tests
{
    [TestClass()]
    public class ServerApiTests
    {
        private ServerApi _serverApi;

        public ServerResponse WebException { get; private set; }

        /// <summary>
        /// LV 3, verify specific method be called
        /// </summary>
        [TestMethod()]
        public void post_cancelGame_third_party_exception_test()
        {
            // Assert SaveFailRequestToDb() be called once
            //Assert.Fail();
            //arrange:
            var fakeServerapi = Substitute.For<ServerApi>();
            //act:
            fakeServerapi.SaveFailRequestToDb(Arg.Any<ApiType>(), Arg.Any<string>()).Throws<WebException>();
            var actual = fakeServerapi.CancelGame();
            //assert:
            Assert.AreEqual(WebException, actual);
        }

        /// <summary>
        /// LV 2, verify specific exception be thrown
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(AuthFailException))]
        public void post_cancelGame_third_party_fail_test()
        {
            // Assert PostToThirdParty() return not correct should throw AuthFailException
            //Assert.Fail();
            //arrange:
            var fakeServerApi = Substitute.For<ServerApi>();

            //act:
            fakeServerApi.PostToThirdParty(Arg.Any<ApiType>(), Arg.Any<string>()).ReturnsForAnyArgs(99);
            var actual = fakeServerApi.CancelGame();
            //assert:
            Assert.AreEqual(ServerResponse.AuthFail, actual);
        }

        /// <summary>
        /// LV 1, verify api correct response
        /// </summary>
        [TestMethod()]
        public void post_cancelGame_third_party_success_test()
        {
            // Assert success
            //Assert.Fail();
            //arrange:
            var fakeServerApi = Substitute.For<ServerApi>();
            //act:
            fakeServerApi.PostToThirdParty(Arg.Any<ApiType>(), Arg.Any<string>()).ReturnsForAnyArgs(0);
            var actual = fakeServerApi.CancelGame();
            //assert:
            Assert.AreEqual(ServerResponse.Correct, actual);
        }
    }
}