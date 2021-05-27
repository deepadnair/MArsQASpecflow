Feature: ManageListing ShareSkill
	Add Shareskill Page and Edit and View Using ManageListing

@mytag
    Scenario: Add Skill In the Share Skill Page
	Given User Click on Share Skill Button fron Profile Page
	And  User enter the entire Required Fields
	When User Click on Save Button to Add the Skills
	Then Check whether New skills are created sucessfully

	Scenario: Edit Skill In Manage Listing Page
	Given User have Navigated to Manage Listing Page
	Then  User Check on ActiveService
	And  User Press Edit Icon which Navigates to Share Skill Page   
	And  User edit the fields and Click on Save Button
	Then Click on View Icon in Manage Listing page to see the changes.

	Scenario:Delete Skill In Manage Listing Page
	Given User is on  the Manage Listing Page
	And User Clicks  on Delete Icon 
	Then User should get an Alert for deletion 
	And User should be able to Delete the Skill
