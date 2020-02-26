using DatabaseFirstProject2.Database.Models;
using NUnit.Framework;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace DatabaseFirstProject2.Tests.Steps
{
    [Binding]
    public class _1_1BrandRepositorySteps
    {
        private BikeStoresContext _repository;

        [Given(@"I have entered to the database repository")]
        [When(@"I enter to the database repository")]
        public void GivenIHaveEnteredToTheDatabaseRepository()
        {
            _repository = new BikeStoresContext();
        }

        /// <summary>
        /// These two steps for creating a new Brand 
        /// </summary>
        [When(@"I complete entering information")]
        public void WhenICompleteEnteringInformation()
        {
            _repository.Brands.Add(new Brand() { BrandName = "Test2" });
            _repository.SaveChanges();
        }

        [Then(@"entered data should be in the repository")]
        public void ThenEnteredDataShouldBeInTheRepository()
        {
            Assert.IsNotNull(_repository.Brands.Select(x => x.BrandId));
        }

        /// <summary>
        /// These two steps for getting all data from Brand repository
        /// </summary>
        [When(@"I send request to get all data to Brand repository")]
        public void WhenISendRequestToGetAllDataToBrandRepository()
        {
            var result = _repository.Brands.Count();
        }

        [Then(@"all brand data should be displayed")]
        public void ThenAllBrandDataShouldBeDisplayed()
        {
            Assert.IsNotNull(_repository.Brands.Count());
        }

        /// <summary>
        /// These two steps for deleting row in Brand repository by id
        /// </summary>
        /// <param name="idNumber">Id Number</param>
        [When(@"I delete from Brand table by ""(.*)"" id")]
        public void WhenIDeleteFromBrandTableById(int idNumber)
        {
            Brand deleteBrand = _repository.Brands.Find(idNumber);
            _repository.Brands.Remove(deleteBrand);
            _repository.SaveChanges();
        }

        [Then(@"id ""(.*)"" should not by in Brand repository")]
        public void ThenIdShouldNotByInBrandRepository(int idNumber)
        {
            Assert.IsNull(_repository.Brands.Find(idNumber));
        }

        /// <summary>
        /// These step check that there is no duplicates in the database repository
        /// </summary>
        [Then(@"should be no duplicates in the Brand repository")]
        public void ThenShouldBeNoDuplicatesInTheBrandRepository()
        {
            Assert.IsNull(_repository.Brands.GroupBy(v => v.BrandName).Where(g => g.Count() > 1).Select(g => g.Key));
        }
    }
}
