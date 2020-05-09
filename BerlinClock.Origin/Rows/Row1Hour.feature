Feature: Row1Hour
	In order to avoid mistakes
	I check if the second row (RowOneHour) of the Berliner clock

@Row1hour

Scenario: RowOneHour at 00:00
Given I implement the second row of the Berlin clock
When the hour for RowOnehours is "0"
Then the following values for RowOnehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | false  | false  | false  | false  |

Scenario: RowOneHour at 01:00
Given I implement the second row of the Berlin clock
When the hour for RowOnehours is "1"
Then the following values for RowOnehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | false  | false  | false  |

Scenario: RowOneHour at 02:00
Given I implement the second row of the Berlin clock
When the hour for RowOnehours is "2"
Then the following values for RowOnehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | false  | false  |

Scenario: RowOneHour at 03:00
Given I implement the second row of the Berlin clock
When the hour for RowOnehours is "3"
Then the following values for RowOnehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | true  | false  |

Scenario: RowOneHour at 04:00
Given I implement the second row of the Berlin clock
When the hour for RowOnehours is "4"
Then the following values for RowOnehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | true  | true  |

Scenario: RowOneHour at 05:00
Given I implement the second row of the Berlin clock
When the hour for RowOnehours is "5"
Then the following values for RowOnehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | false  | false  | false  | false  |

Scenario: RowOneHour at 06:00
Given I implement the second row of the Berlin clock
When the hour for RowOnehours is "6"
Then the following values for RowOnehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | false  | false  | false  |

Scenario: RowOneHour at 07:00
Given I implement the second row of the Berlin clock
When the hour for RowOnehours is "7"
Then the following values for RowOnehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | false  | false  |

Scenario: RowOneHour at 08:00
Given I implement the second row of the Berlin clock
When the hour for RowOnehours is "8"
Then the following values for RowOnehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | true  | false  |

Scenario: RowOneHour at 09:00
Given I implement the second row of the Berlin clock
When the hour for RowOnehours is "9"
Then the following values for RowOnehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | true  | true  |

Scenario: RowOneHour at 10:00
Given I implement the second row of the Berlin clock
When the hour for RowOnehours is "10"
Then the following values for RowOnehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | false  | false  | false  | false  |

Scenario: RowOneHour at 11:00
Given I implement the second row of the Berlin clock
When the hour for RowOnehours is "11"
Then the following values for RowOnehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | false  | false  | false  |

Scenario: RowOneHour at 12:00
Given I implement the second row of the Berlin clock
When the hour for RowOnehours is "12"
Then the following values for RowOnehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | false  | false  |

Scenario: RowOneHour at 13:00
Given I implement the second row of the Berlin clock
When the hour for RowOnehours is "13"
Then the following values for RowOnehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | true  | false  |

Scenario: RowOneHour at 14:00
Given I implement the second row of the Berlin clock
When the hour for RowOnehours is "14"
Then the following values for RowOnehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | true  | true  |


Scenario: RowOneHour at 15:00
Given I implement the second row of the Berlin clock
When the hour for RowOnehours is "15"
Then the following values for RowOnehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | false  | false  | false  | false  |

Scenario: RowOneHour at 16:00
Given I implement the second row of the Berlin clock
When the hour for RowOnehours is "16"
Then the following values for RowOnehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | false  | false  | false  |

Scenario: RowOneHour at 17:00
Given I implement the second row of the Berlin clock
When the hour for RowOnehours is "17"
Then the following values for RowOnehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | false  | false  |

Scenario: RowOneHour at 18:00
Given I implement the second row of the Berlin clock
When the hour for RowOnehours is "18"
Then the following values for RowOnehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | true  | false  |

Scenario: RowOneHour at 19:00
Given I implement the second row of the Berlin clock
When the hour for RowOnehours is "19"
Then the following values for RowOnehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | true  | true  |


Scenario: RowOneHour at 20:00
Given I implement the second row of the Berlin clock
When the hour for RowOnehours is "20"
Then the following values for RowOnehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | false  | false  | false  | false  |

Scenario: RowOneHour at 21:00
Given I implement the second row of the Berlin clock
When the hour for RowOnehours is "21"
Then the following values for RowOnehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | false  | false  | false  |

Scenario: RowOneHour at 22:00
Given I implement the second row of the Berlin clock
When the hour for RowOnehours is "22"
Then the following values for RowOnehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | false  | false  |

Scenario: RowOneHour at 23:00
Given I implement the second row of the Berlin clock
When the hour for RowOnehours is "23"
Then the following values for RowOnehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | true  | false  |

Scenario: RowOneHour at 24:00
Given I implement the second row of the Berlin clock
When the hour for RowOnehours is "24"
Then the following values for RowOnehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | true  | true  |