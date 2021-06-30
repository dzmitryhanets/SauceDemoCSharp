Feature: Login To Application

Scenario: Login as problem user
	Given SauceDemo page is opened in browser
	When login as 'troubleUser'
	Then error message 'Epic sadface: Sorry, this user has been locked out.' appears

Scenario: Login as standard user
	Given SauceDemo page is opened in browser
	When login as 'standardUser'
	Then user is redirected to 'PRODUCTS' page