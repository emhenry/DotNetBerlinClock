Feature: Row5Hours
	In order to avoid mistakes
	I check the first row (row 5 hours) of the Berliner clock

@Row5hours
Scenario: RowFiveHours at 00:00
	Given I implement the first row of the Berlin clock
	When the hour for RowFiveHours is "0"
	Then the following values for RowFiveHours are valid
		| Light1 | Light2 | Light3 | Light4 |
		| false  | false  | false  | false  |

Scenario: RowFiveHours at 01:00
	Given I implement the first row of the Berlin clock
	When the hour for RowFiveHours is "1"
	Then the following values for RowFiveHours are valid
		| Light1 | Light2 | Light3 | Light4 |
		| false  | false  | false  | false  |

Scenario: RowFiveHours at 02:00
	Given I implement the first row of the Berlin clock
	When the hour for RowFiveHours is "2"
	Then the following values for RowFiveHours are valid
		| Light1 | Light2 | Light3 | Light4 |
		| false  | false  | false  | false  |

Scenario: RowFiveHours at 03:00
	Given I implement the first row of the Berlin clock
	When the hour for RowFiveHours is "3"
	Then the following values for RowFiveHours are valid
		| Light1 | Light2 | Light3 | Light4 |
		| false  | false  | false  | false  |

Scenario: RowFiveHours at 04:00
	Given I implement the first row of the Berlin clock
	When the hour for RowFiveHours is "4"
	Then the following values for RowFiveHours are valid
		| Light1 | Light2 | Light3 | Light4 |
		| false  | false  | false  | false  |

Scenario: RowFiveHours at 05:00
	Given I implement the first row of the Berlin clock
	When the hour for RowFiveHours is "5"
	Then the following values for RowFiveHours are valid
		| Light1 | Light2 | Light3 | Light4 |
		| true   | false  | false  | false  |

Scenario: RowFiveHours at 06:00
	Given I implement the first row of the Berlin clock
	When the hour for RowFiveHours is "6"
	Then the following values for RowFiveHours are valid
		| Light1 | Light2 | Light3 | Light4 |
		| true   | false  | false  | false  |

Scenario: RowFiveHours at 07:00
	Given I implement the first row of the Berlin clock
	When the hour for RowFiveHours is "7"
	Then the following values for RowFiveHours are valid
		| Light1 | Light2 | Light3 | Light4 |
		| true   | false  | false  | false  |

Scenario: RowFiveHours at 08:00
	Given I implement the first row of the Berlin clock
	When the hour for RowFiveHours is "8"
	Then the following values for RowFiveHours are valid
		| Light1 | Light2 | Light3 | Light4 |
		| true   | false  | false  | false  |

Scenario: RowFiveHours at 09:00
	Given I implement the first row of the Berlin clock
	When the hour for RowFiveHours is "9"
	Then the following values for RowFiveHours are valid
		| Light1 | Light2 | Light3 | Light4 |
		| true   | false  | false  | false  |

Scenario: RowFiveHours at 10:00
	Given I implement the first row of the Berlin clock
	When the hour for RowFiveHours is "10"
	Then the following values for RowFiveHours are valid
		| Light1 | Light2 | Light3 | Light4 |
		| true   | true   | false  | false  |

Scenario: RowFiveHours at 11:00
	Given I implement the first row of the Berlin clock
	When the hour for RowFiveHours is "11"
	Then the following values for RowFiveHours are valid
		| Light1 | Light2 | Light3 | Light4 |
		| true   | true   | false  | false  |

Scenario: RowFiveHours at 12:00
	Given I implement the first row of the Berlin clock
	When the hour for RowFiveHours is "12"
	Then the following values for RowFiveHours are valid
		| Light1 | Light2 | Light3 | Light4 |
		| true   | true   | false  | false  |

Scenario: RowFiveHours at 13:00
	Given I implement the first row of the Berlin clock
	When the hour for RowFiveHours is "13"
	Then the following values for RowFiveHours are valid
		| Light1 | Light2 | Light3 | Light4 |
		| true   | true   | false  | false  |

Scenario: RowFiveHours at 14:00
	Given I implement the first row of the Berlin clock
	When the hour for RowFiveHours is "14"
	Then the following values for RowFiveHours are valid
		| Light1 | Light2 | Light3 | Light4 |
		| true   | true   | false  | false  |

Scenario: RowFiveHours at 15:00
	Given I implement the first row of the Berlin clock
	When the hour for RowFiveHours is "15"
	Then the following values for RowFiveHours are valid
		| Light1 | Light2 | Light3 | Light4 |
		| true   | true   | true   | false  |

Scenario: RowFiveHours at 16:00
	Given I implement the first row of the Berlin clock
	When the hour for RowFiveHours is "16"
	Then the following values for RowFiveHours are valid
		| Light1 | Light2 | Light3 | Light4 |
		| true   | true   | true   | false  |

Scenario: RowFiveHours at 17:00
	Given I implement the first row of the Berlin clock
	When the hour for RowFiveHours is "17"
	Then the following values for RowFiveHours are valid
		| Light1 | Light2 | Light3 | Light4 |
		| true   | true   | true   | false  |

Scenario: RowFiveHours at 18:00
	Given I implement the first row of the Berlin clock
	When the hour for RowFiveHours is "18"
	Then the following values for RowFiveHours are valid
		| Light1 | Light2 | Light3 | Light4 |
		| true   | true   | true   | false  |

Scenario: RowFiveHours at 19:00
	Given I implement the first row of the Berlin clock
	When the hour for RowFiveHours is "19"
	Then the following values for RowFiveHours are valid
		| Light1 | Light2 | Light3 | Light4 |
		| true   | true   | true   | false  |

Scenario: RowFiveHours at 20:00
	Given I implement the first row of the Berlin clock
	When the hour for RowFiveHours is "20"
	Then the following values for RowFiveHours are valid
		| Light1 | Light2 | Light3 | Light4 |
		| true   | true   | true   | true   |

Scenario: RowFiveHours at 21:00
	Given I implement the first row of the Berlin clock
	When the hour for RowFiveHours is "21"
	Then the following values for RowFiveHours are valid
		| Light1 | Light2 | Light3 | Light4 |
		| true   | true   | true   | true   |

Scenario: RowFiveHours at 22:00
	Given I implement the first row of the Berlin clock
	When the hour for RowFiveHours is "22"
	Then the following values for RowFiveHours are valid
		| Light1 | Light2 | Light3 | Light4 |
		| true   | true   | true   | true   |

Scenario: RowFiveHours at 23:00
	Given I implement the first row of the Berlin clock
	When the hour for RowFiveHours is "23"
	Then the following values for RowFiveHours are valid
		| Light1 | Light2 | Light3 | Light4 |
		| true   | true   | true   | true   |

Scenario: RowFiveHours at 24:00
	Given I implement the first row of the Berlin clock
	When the hour for RowFiveHours is "24"
	Then the following values for RowFiveHours are valid
		| Light1 | Light2 | Light3 | Light4 |
		| true   | true   | true   | true   |