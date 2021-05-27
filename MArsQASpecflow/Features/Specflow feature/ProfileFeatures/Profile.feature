Feature: Profile Feature
	Simple calculator for adding two numbers

@mytag
Scenario: Add Details to Availability 
Given User is on Profile Tab
And User Clicks on Availabiltytimelink
Then Choose one option from the dropdown.

Scenario: Add Details to AvailabilityHour 
Given User is on Profile Tab
And User Clicks on AvailabiltyHourlink
Then Choose one hour option from the dropdown.

Scenario: Add Details to EarnTarget 
Given User is on Profile Tab
And User Clicks on EarnTargetlink
Then Choose one Target option from the dropdown.

Scenario: Add Description Details
Given User is on Profile Tab
And User Clicks on Descriptiontab
And User adds Description text
Then Savethe description and Verify the details

Scenario: Change Password in Profile Page
Given the user is on Profile tab
And the user Clicks on User tab and changepassword link
And the user inputs current password,new password and confirmpassword
And Clicks on save button the details are saved

Scenario: Chat option in Profile Page
Given the user is on Profile tab
And the user Clicks on Chat tab Chat screen opens
When the user inputs name in search input box
Then Chats between the input name and user should be visible 
And to send message add message in input box
And Clicks on send button

Scenario: RefineSearch Skills in Profile Page
Given the user is on Profile tab
And the user inputs search key in search inputbox and click on searchicon
When the user input search key Refine search and click on searchicon
And the user input search user key search user and click on searchicon
Then the refined search items should be Displayed
Scenario: Search Skills by Filter 
Given the user is on Profile tab
And the user inputs search key in search inputbox and click on searchicon
When the user input search key Refine search and click on searchicon
And add  any of the filters the filtered search should be displayed



