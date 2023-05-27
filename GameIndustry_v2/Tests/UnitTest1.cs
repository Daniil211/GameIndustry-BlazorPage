using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using GameIndustry_v2;
using Application.Persistence;
using Application.Persistence.Models;
using GameIndustry_v2.Data;
using Microsoft.AspNetCore.Components;
using Moq;
using System.Text;
using System.Reflection;
using GameIndustry_v2.PageComponents;

namespace Tests
{
    [TestFixture]
    public class GameCardTests
    {
//        [Test]
//        public async Task GameCardRendersCorrectly()
//        {
//            // Arrange
//            var game = new GameModel
//            {
//                Id = 1,
//                Name = "Test Game",
//                Image = "data:image/jpeg;base64,base64string"
//            };
//            var component = new IndividualGame
//            {
//                Game = game,
//                OnDeleteGame = EventCallback.Factory.Create<GameModel>(this, _ => { }),
//                OnEditGame = EventCallback.Factory.Create<GameModel>(this, _ => { })
//            };

//            // Act
//            await component.SetParametersAsync(ParameterView.FromDictionary(new Dictionary<string, object>
//{
//    { nameof(IndividualGame.Game), game },
//    { nameof(IndividualGame.OnDeleteGame), EventCallback.Factory.Create<GameModel>(this, _ => { }) },
//    { nameof(IndividualGame.OnEditGame), EventCallback.Factory.Create<GameModel>(this, _ => { }) }
//}));
//            var urlField = component.GetType().GetField("url", BindingFlags.Instance | BindingFlags.NonPublic);
//            var url = (string)urlField.GetValue(component);

//            // Assert
//            Assert.AreEqual("games/1/Test%20Game", url);
//        }
    }
}