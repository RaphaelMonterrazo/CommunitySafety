
using CommunitySafety.Domain.Entities;
using CommunitySafety.Domain.Exceptions;

namespace CommunitySafety.Domain.Tests
{
    public class CategoryTest
    {
        [Fact(DisplayName = "Create Category with valid parameters")]
        public void CreateCategory_WithValidParameters_ResultObjectValidState()
        {
            // Arrange
            var nomeValido = "Roubo";

            // Act
            var category = new Category(nomeValido);

            // Assert
            Assert.Equal(nomeValido, category.Name);
        }

        [Fact(DisplayName = "Create Category with null name")]
        public void CreateCategory_WithNullName_DomainException_NullOrEmptyName()
        {
            // Arrange
            var expectedErroCode = "E001";
            var expectedErroMessage = "Invalid Name.  Null or Empty name is not allowed";

            // Act
            Action action = () => new Category(null);

            // Assert
            var exception = Assert.Throws<DomainException>(action);

            Assert.Equal(expectedErroCode, exception.ErrorCode);
            Assert.Equal(expectedErroMessage, exception.Message);

        }

        [Fact(DisplayName = "Create Category with empty name")]
        public void CreateCategory_WithEmptyName_DomainException_NullOrEmptyName()
        {
            // Arrange
            var expectedErroCode = "E001";
            var expectedErroMessage = "Invalid Name.  Null or Empty name is not allowed";

            // Act
            Action action = () => new Category(string.Empty);

            // Assert
            var exception = Assert.Throws<DomainException>(action);

            Assert.Equal(expectedErroCode, exception.ErrorCode);
            Assert.Equal(expectedErroMessage, exception.Message);

        }

    }
}
