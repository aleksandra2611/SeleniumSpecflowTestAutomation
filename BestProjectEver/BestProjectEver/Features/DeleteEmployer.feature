Feature: Delete  Employer

@some
Scenario: Create new Employer
	Given I launch the application
	And  I Click Login link
	And I enter the following details
		| UserName | Password |
		| admin    | password |
	And  I click login button
	When  I click on the Employee List link
	And I click on the Create New button
	And I fill the Employee Details
		| Name       | Salary | DurationWorked | Grade | Email          |
		| Aleksandra | 400 | 100            | 10    | alex@gmail.com |
	And I click on the Create Button
	And I Searche 'Aleksandra' Employer
	And I deleted the Employer 'Aleksandra'
	And Confrm Delete button