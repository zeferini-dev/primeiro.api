using Bogus;
using NetCore.Base;
using Primeiro.Domain.Builders;

namespace Primeiro.Domain.Tests
{
    public class MovieTest
    {
        private readonly Faker _faker;

        public MovieTest()
        {
            _faker = new Faker();
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]        
        public void Movie_Should_Not_Be_Created_With_Invalid_Name(string name)
        {
            Assert.Throws<BaseException>(() => new MovieBuilder().WithName(name).Build())
                  .WithMessage(Resources.Common.NameIsRequired);
        }
    }
}