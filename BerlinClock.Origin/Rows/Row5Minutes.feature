Feature: Row5Minutes
	In order to avoid mistakes
	I check the third row (RowFiveMinutes) of the Berliner clock

@Row5minutes
Scenario: RowFiveMinutes at 00:00
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "0"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| false  | false  | false  | false  | false  | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:01
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "1"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| false  | false  | false  | false  | false  | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:02
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "2"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| false  | false  | false  | false  | false  | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:03
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "3"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| false  | false  | false  | false  | false  | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:04
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "4"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| false  | false  | false  | false  | false  | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:05
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "5"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | false  | false  | false  | false  | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:06
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "6"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | false  | false  | false  | false  | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:07
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "7"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | false  | false  | false  | false  | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:08
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "8"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | false  | false  | false  | false  | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:09
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "9"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | false  | false  | false  | false  | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:10
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "10"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | false  | false  | false  | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:11
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "11"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | false  | false  | false  | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:12
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "12"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | false  | false  | false  | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:13
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "13"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | false  | false  | false  | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:14
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "14"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | false  | false  | false  | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:15
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "15"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | false  | false  | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:16
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "16"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | false  | false  | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:17
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "17"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | false  | false  | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:18
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "18"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | false  | false  | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:19
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "19"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | false  | false  | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:20
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "20"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | false  | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:21
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "21"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | false  | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:22
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "22"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | false  | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:23
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "23"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | false  | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:24
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "24"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | false  | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:25
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "25"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:26
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "26"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:27
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "27"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:28
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "28"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:29
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "29"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | false  | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:30
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "30"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:31
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "31"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:32
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "32"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:33
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "33"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:34
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "34"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | false  | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:35
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "35"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | true   | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:36
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "36"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | true   | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:37
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "37"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | true   | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:38
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "38"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | true   | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:39
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "39"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | true   | false  | false  | false   | false   |

Scenario: RowFiveMinutes at 00:40
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "40"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | true   | true   | false  | false   | false   |

Scenario: RowFiveMinutes at 00:41
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "41"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | true   | true   | false  | false   | false   |

Scenario: RowFiveMinutes at 00:42
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "42"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | true   | true   | false  | false   | false   |

Scenario: RowFiveMinutes at 00:43
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "43"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | true   | true   | false  | false   | false   |

Scenario: RowFiveMinutes at 00:44
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "44"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | true   | true   | false  | false   | false   |

Scenario: RowFiveMinutes at 00:45
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "45"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | true   | true   | true   | false   | false   |

Scenario: RowFiveMinutes at 00:46
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "46"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | true   | true   | true   | false   | false   |

Scenario: RowFiveMinutes at 00:47
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "47"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | true   | true   | true   | false   | false   |

Scenario: RowFiveMinutes at 00:48
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "48"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | true   | true   | true   | false   | false   |

Scenario: RowFiveMinutes at 00:49
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "49"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | true   | true   | true   | false   | false   |

Scenario: RowFiveMinutes at 00:50
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "50"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | true   | true   | true   | true    | false   |

Scenario: RowFiveMinutes at 00:51
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "51"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | true   | true   | true   | true    | false   |

Scenario: RowFiveMinutes at 00:52
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "52"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | true   | true   | true   | true    | false   |

Scenario: RowFiveMinutes at 00:53
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "53"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | true   | true   | true   | true    | false   |

Scenario: RowFiveMinutes at 00:54
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "54"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | true   | true   | true   | true    | false   |

Scenario: RowFiveMinutes at 00:55
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "55"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | true   | true   | true   | true    | true    |

Scenario: RowFiveMinutes at 00:56
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "56"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | true   | true   | true   | true    | true    |

Scenario: RowFiveMinutes at 00:57
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "57"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | true   | true   | true   | true    | true    |

Scenario: RowFiveMinutes at 00:58
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "58"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | true   | true   | true   | true    | true    |

Scenario: RowFiveMinutes at 00:59
	Given I implement the third row of the Berlin clock
	When the minute for RowFiveMinutes is "59"
	Then the following values for RowFiveMinutes are valid
		| Light1 | Light2 | Light3 | Light4 | Light5 | Light6 | Light7 | Light8 | Light9 | Light10 | Light11 |
		| true   | true   | true   | true   | true   | true   | true   | true   | true   | true    | true    |