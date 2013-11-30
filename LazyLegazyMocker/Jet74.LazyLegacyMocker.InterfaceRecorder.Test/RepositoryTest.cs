using System;
using Jet74.LazyLegacyMocker.Tests.Model;
using Xunit;

namespace Jet74.LazyLegacyMocker.InterfaceRecorder.Test
{
    public class RepositoryTest : IDisposable
    {
        private Repository _repo;
        public RepositoryTest()
        {
            _repo = new Repository();
        }

        [Fact]
        public void CanCreateRepository()
        {
            Assert.NotNull(_repo);
        }

        [Fact]
        public void CanAddRecorderToInterface()
        {
            Assert.DoesNotThrow(() => _repo.AddObjectPrinter(ModelFactory.IEmployees));
        }

        [Fact]
        public void CanAddRecorderToClass()
        {
            Assert.DoesNotThrow(() => _repo.AddObjectPrinter(this));
        }

        [Fact]
        public void CanAddRecorderToAllMethodsOfIEmploy()
        {
            var iEmp = _repo.AddObjectPrinter(ModelFactory.IEmployees);

            var emp = iEmp.GetPersonById(0);
            Assert.IsType(typeof(Person), emp);
        }

        [Fact]
        public void CannotUseSealedType()
        {
            Assert.Throws<NotSupportedException>(() => _repo.AddObjectPrinter(new SealedType()));
        }

        public void Dispose()
        {
        }
    }
}
