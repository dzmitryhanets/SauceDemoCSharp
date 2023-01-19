Feature: Cart
	
Background: 
	Given SauceDemo page is opened in browser
	When login as 'standardUser'
		And user selects item #'0' on Products page

Scenario: User is redirected to Cart page
	When user click cart icon
	Then page title is 'YOUR CART11'

Scenario: User is redirected to Products page from Cart
	When user click cart icon
		And user clicks Continue Shopping btn
	Then page title is 'PRODUCTS'