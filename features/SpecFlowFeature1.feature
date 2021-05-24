Feature: ESPN headline feature

@mytag
Scenario: save first headline and take a screenshot
	Given user is on ESPN home page
	Then save first headline to a text file
	Then take a screenshot of the home screenshot