Feature: SystemTimeApi
	In order to avoid mistakes
	I check if the class SystemTimeApi works correctly
	In this feature, I check the different time events

@SystemTimeApi
Scenario: SystemTimeApi at 00:00
	Given I implement the class SystemTimeApi and I subscribe to the event OnHourChanged
	When I start the the System Timer with the hour "0" and the minute "0"
	Then the following values for the hour and the minute are
		| Hour | Minute |
		| 0    | 0      |
	Given I dispose the resources the the System Timer

Scenario: SystemTimeApi at 04:10
	Given I implement the class SystemTimeApi and I subscribe to the event OnHourChanged
	When I start the the System Timer with the hour "4" and the minute "10"
	Then the following values for the hour and the minute are
		| Hour | Minute |
		| 4    | 10     |
	Given I dispose the resources the the System Timer

Scenario: SystemTimeApi at 08:20
	Given I implement the class SystemTimeApi and I subscribe to the event OnHourChanged
	When I start the the System Timer with the hour "8" and the minute "20"
	Then the following values for the hour and the minute are
		| Hour | Minute |
		| 8    | 20     |
	Given I dispose the resources the the System Timer

Scenario: SystemTimeApi at 12:30
	Given I implement the class SystemTimeApi and I subscribe to the event OnHourChanged
	When I start the the System Timer with the hour "12" and the minute "30"
	Then the following values for the hour and the minute are
		| Hour | Minute |
		| 12   | 30     |
	Given I dispose the resources the the System Timer

Scenario: SystemTimeApi at 16:40
	Given I implement the class SystemTimeApi and I subscribe to the event OnHourChanged
	When I start the the System Timer with the hour "16" and the minute "40"
	Then the following values for the hour and the minute are
		| Hour | Minute |
		| 16   | 40     |
	Given I dispose the resources the the System Timer

Scenario: SystemTimeApi at 20:50
	Given I implement the class SystemTimeApi and I subscribe to the event OnHourChanged
	When I start the the System Timer with the hour "20" and the minute "50"
	Then the following values for the hour and the minute are
		| Hour | Minute |
		| 20   | 50     |
	Given I dispose the resources the the System Timer