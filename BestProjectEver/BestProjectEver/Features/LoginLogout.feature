Feature: Login to EA Demo application

@some
Scenario: Perform to Login of EA Application site
	Given I launch the application
	And  I Click Login link
	And I enter the following details
		| UserName | Password |
		| admin    | password |
	And  I click login button
	Then I should see Employee details link
	And I click on the Logout button 
	Then I'm logged out
