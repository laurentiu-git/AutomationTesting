Feature: SpinFeature

@sometag
Scenario: SpinFeature
	Given I go to Casion
	And I Log In
	Then I expect to be LoggedIn
	And I go to the "Trail of Treats" game
	And I click on demo button
	And I click on spin button