Feature: Login
	Check if login functionality works


@Regression
Scenario Outline: Login user successfully
	Given I navigate to application
	And I enter <username> and <password>
	And I click login
	Then I should see user logged in to the application
	Examples: 
	| username   | password |
    | standard_user | secret_sauce |