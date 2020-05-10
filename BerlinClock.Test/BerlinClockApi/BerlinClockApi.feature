Feature: BerlinClockApi
	In order to avoid mistakes
	I check if the class BerlinClockApi works correctly
	In this feature, I check the different time events of all the 4 rows of the Berlin clock

@SystemTimeApi
Scenario: BerlinClockApi at 00:00
	Given I implement the class BerlinClockApi
	Given I subscribe to the row events
	When I start the the the Berlin clock with the hour "0" and the minute "0"
	Then the following lights on for the Berlin clock are
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| false  | false  | false  | false  | #N/A   | #N/A   | #N/A   | #N/A   | #N/A   | #N/A    | #N/A    |
		| false  | false  | false  | false  | #N/A   | #N/A   | #N/A   | #N/A   | #N/A   | #N/A    | #N/A    |
		| false  | false  | false  | false  | false  | false  | false  | false  | false  | false   | false   |
		| false  | false  | false  | false  | #N/A   | #N/A   | #N/A   | #N/A   | #N/A   | #N/A    | #N/A    |
	Given I dispose the resources the BerlinClockApi

Scenario: BerlinClockApi at 11:36
	Given I implement the class BerlinClockApi
	Given I subscribe to the row events
	When I start the the the Berlin clock with the hour "11" and the minute "36"
	Then the following lights on for the Berlin clock are
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | false  | false  | #N/A   | #N/A   | #N/A   | #N/A   | #N/A   | #N/A    | #N/A    |
		| true   | false  | false  | false  | #N/A   | #N/A   | #N/A   | #N/A   | #N/A   | #N/A    | #N/A    |
		| true   | true   | true   | true   | true   | true   | true   | false  | false  | false   | false   |
		| true   | false  | false  | false  | #N/A   | #N/A   | #N/A   | #N/A   | #N/A   | #N/A    | #N/A    |
	Given I dispose the resources the BerlinClockApi

Scenario: BerlinClockApi at 23:59
	Given I implement the class BerlinClockApi
	Given I subscribe to the row events
	When I start the the the Berlin clock with the hour "23" and the minute "59"
	Then the following lights on for the Berlin clock are
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | #N/A   | #N/A   | #N/A   | #N/A   | #N/A   | #N/A    | #N/A    |
		| true   | true   | true   | false  | #N/A   | #N/A   | #N/A   | #N/A   | #N/A   | #N/A    | #N/A    |
		| true   | true   | true   | true   | true   | true   | true   | true   | true   | true    | true    |
		| true   | true   | true   | true   | #N/A   | #N/A   | #N/A   | #N/A   | #N/A   | #N/A    | #N/A    |
	Given I dispose the resources the BerlinClockApi

Scenario: BerlinClockApi at 24:00
	Given I implement the class BerlinClockApi
	Given I subscribe to the row events
	When I start the the the Berlin clock with the hour "24" and the minute "0"
	Then the following lights on for the Berlin clock are
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| false  | false  | false  | false  | #N/A   | #N/A   | #N/A   | #N/A   | #N/A   | #N/A    | #N/A    |
		| false  | false  | false  | false  | #N/A   | #N/A   | #N/A   | #N/A   | #N/A   | #N/A    | #N/A    |
		| false  | false  | false  | false  | false  | false  | false  | false  | false  | false   | false   |
		| false  | false  | false  | false  | #N/A   | #N/A   | #N/A   | #N/A   | #N/A   | #N/A    | #N/A    |
	Given I dispose the resources the BerlinClockApi