Feature: guru99Selenium
	In order to check login feature
	As a user
	I want to check if login to bank is successful

@mytag
Scenario: Login to Guru99 Bank
	Given I open firefox
	And I go to "http://www.demo.guru99.com/V4/"
	When I enter username of "mngr111938"
	And I enter password of "abyvUqe"
	And I click login
	Then I should be logged-in with success message "Welcome To Manager's Page of Guru99 Bank"
	And I close the browser
