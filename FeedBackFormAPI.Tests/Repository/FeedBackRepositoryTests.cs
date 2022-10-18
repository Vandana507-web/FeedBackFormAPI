using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using FeedBackForm.Data;
using FeedBackForm.Models;
using FeedBackForm.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FeedBackForm.Tests.Repository
{
    public class FeedBackRepositoryTests
    {

        private async Task<FeedBack_DbContext> GetDatabaseContext()
        {
            var options = new DbContextOptionsBuilder<FeedBack_DbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            var databaseContext = new FeedBack_DbContext(options);
            databaseContext.Database.EnsureCreated();
            if (await databaseContext.Feedbacks.CountAsync() <= 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    databaseContext.Feedbacks.Add(
                    new Feedback()
                    {
                        Username = "Vandana",
                        Email = "vandadan@gmail.com",
                        Phoneno=9035997204,
                        timeofinterview="Yes",
                        disussion="Yes",
                        notes="OK",
                        posts="Software Engineering",
                       topics= new List<string>{ "AdditionalCardPersonAdressType", "data" }
                     
                    });
                    await databaseContext.SaveChangesAsync();
                }
            }
            return databaseContext;
        }
       // [Fact]
        public async void FeedBackRepository_GetFeedback_ReturnsFeedBack()
        {
            //Arrange
            var name = "Vandana";
            var dbContext = await GetDatabaseContext();
            var feedbackRepository = new FeedBackRepository(dbContext);

            //Act
            var result = feedbackRepository.GetFeedback(name);

            //Assert
            result.Should().NotBeNull();
            result.Should().BeOfType<Feedback>();
        }

     
    }
}
//unit test angular
//daigrams
//readme 
//production ready 

//component -optional
//dotnet good 