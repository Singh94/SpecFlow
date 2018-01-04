Feature: SpecFlowFeature2
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Take x numbers
	Given I entered 50 into the calculator
	And I entered 70 into the calculator
	And I entered 90 into the calculator
	And I entered 110 into the calculator
	And I entered 130 into the calculator
	And I split numbers into arrays
	When I press calculation
	Then the result should be 25.384615 on the screen


Take x numbers
	add			first 2
	minus		third
	multiply	fourth
	divide		fifth

	repeat if needed