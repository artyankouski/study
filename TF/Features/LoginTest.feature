Feature: LoginTest
	
@mytag
Scenario: Login
	Given I launch browser and go to DC login page
	And I fill in <username> and <password>   
	When I select client site
	Then navigated to Home Page

@source:inputs.xlsx
Examples: 
		| username | password |