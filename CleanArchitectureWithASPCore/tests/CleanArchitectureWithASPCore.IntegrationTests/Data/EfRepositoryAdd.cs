using CleanArchitectureWithASPCore.Core.Entities;
using CleanArchitectureWithASPCore.UnitTests;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace CleanArchitectureWithASPCore.IntegrationTests.Data
{
    public class EfRepositoryAdd : BaseEfRepoTestFixture
    {
        [Fact]
        public async Task AddsItemAndSetsId()
        {
            var repository = GetRepository();
            var item = new ToDoItemBuilder().Build();

            await repository.AddAsync(item);

            var newItem = (await repository.ListAsync<ToDoItem>())
                            .FirstOrDefault();

            Assert.Equal(item, newItem);
            Assert.True(newItem?.Id > 0);
        }
    }
}
