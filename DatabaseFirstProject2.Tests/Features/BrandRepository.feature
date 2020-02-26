Feature: 1.1 Brand Repository
	In order to check table Brand in database BikeStores
	As a database user
	I want to get correct results

@mytag
Scenario: Get all data from Brand repository
    When I enter to the database repository
    Then all brand data should be displayed

@mytag
Scenario: Enter data to the Brand repository
	Given I have entered to the database repository
	When I complete entering information
	Then entered data should be in the repository

@mytag
Scenario: Delete from Brand repository by id
	Given I have entered to the database repository
	When I delete from Brand table by "1004" id
	Then id "1004" should not by in Brand repository

@mytag
Scenario: Check that in the Brand repository no duplicates
	When I enter to the database repository
	Then should be no duplicates in the Brand repository 