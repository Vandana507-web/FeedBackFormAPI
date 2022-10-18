using AutoMapper;
using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using FeedBackForm.Controllers;
using FeedBackForm.Dto;
using FeedBackForm.Interfaces;
using FeedBackForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FeedBackForm.Tests.Controller
{
    public class FeedBackControllerTests
    {

        private readonly IFeedBackRepository _feedBackRepository;
        private readonly IMapper _mapper;
        public FeedBackControllerTests()
        {  
            _feedBackRepository = A.Fake<IFeedBackRepository>();
            _mapper = A.Fake<IMapper>();
        }

        [Fact]
        public void FeedBackController_GetFeedBack_ReturnOK()
        {
            //Arrange
            var feedBack = A.Fake<ICollection<FeedBackDto>>();
            var feedBackList = A.Fake<List<FeedBackDto>>();
            A.CallTo(() => _mapper.Map<List<FeedBackDto>>(feedBack)).Returns(feedBackList);
            var controller = new FeedBackFormController(_feedBackRepository, _mapper);

            //Act
            var result = controller.GetFeedBacks();

            //Assert
            result.Should().NotBeNull();
            result.Should().BeOfType(typeof(OkObjectResult));
        }

        [Fact]
        public void FeedBackController_CreateFeedback_ReturnOK()
        {

            var feedbackMap = A.Fake<Feedback>();
            var feedBack = A.Fake<Feedback>();
            var feedbackCreate = A.Fake<FeedBackDto>();
            var pokemons = A.Fake<ICollection<FeedBackDto>>();
            var pokmonList = A.Fake<IList<FeedBackDto>>();

            A.CallTo(() => _mapper.Map<Feedback>(feedbackCreate)).Returns(feedBack);
            A.CallTo(() => _feedBackRepository.CreateFeedBack(feedbackMap)).Returns(true);
            var controller = new FeedBackFormController(_feedBackRepository, _mapper);

            //Act
            var result = controller.CreateFeedBack(feedbackCreate);

            //Assert
            result.Should().NotBeNull();
        }
    }
}
