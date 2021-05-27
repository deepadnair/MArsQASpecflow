Feature: Feature: Register
Test the Register functionality 
And verify the credentials working as expected
@mytag
Scenario Outline: Register_Function
Given I press on Join Button
And  <FirstName> and <LastName> entered
And <Email>,	<Password> and	<ConfirmPswd>
And Enter the Terms CheckBox
When I press on Join Button
Then I should be able to Register.
 
@source:TestDatad.xlsx.SignUp
Examples: 
| FirstName | LastName | Email            | Password     | ConfirmPswd  |
| DeepDiv   | Kish     | depdiv@gmail.com | Deep@Connect | Deep@Connect |

	
