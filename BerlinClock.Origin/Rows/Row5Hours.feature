Feature: Row5Hours
	In order to avoid mistakes
	I check if the first row (row 5 hours) of the Berliner clock

@Row5hours

Scenario: Row 5 Hours at 00:00
Given I implement the first row of the Berlin clock
When the hour for RowFivehours is "0"
Then the following values for RowFivehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | false  | false  | false  | false  |

Scenario: RowFivehours at 01:00
Given I implement the first row of the Berlin clock
When the hour for RowFivehours is "1"
Then the following values for RowFivehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | false  | false  | false  | false  |

Scenario: RowFivehours at 02:00
Given I implement the first row of the Berlin clock
When the hour for RowFivehours is "2"
Then the following values for RowFivehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | false  | false  | false  | false  |

Scenario: RowFivehours at 03:00
Given I implement the first row of the Berlin clock
When the hour for RowFivehours is "3"
Then the following values for RowFivehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | false  | false  | false  | false  |

Scenario: RowFivehours at 04:00
Given I implement the first row of the Berlin clock
When the hour for RowFivehours is "4"
Then the following values for RowFivehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | false  | false  | false  | false  |

Scenario: RowFivehours at 05:00
Given I implement the first row of the Berlin clock
When the hour for RowFivehours is "5"
Then the following values for RowFivehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | false  | false  | false  |

Scenario: RowFivehours at 06:00
Given I implement the first row of the Berlin clock
When the hour for RowFivehours is "6"
Then the following values for RowFivehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | false  | false  | false  |

Scenario: RowFivehours at 07:00
Given I implement the first row of the Berlin clock
When the hour for RowFivehours is "7"
Then the following values for RowFivehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | false  | false  | false  |

Scenario: RowFivehours at 08:00
Given I implement the first row of the Berlin clock
When the hour for RowFivehours is "8"
Then the following values for RowFivehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | false  | false  | false  |

Scenario: RowFivehours at 09:00
Given I implement the first row of the Berlin clock
When the hour for RowFivehours is "9"
Then the following values for RowFivehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | false  | false  | false  |

Scenario: RowFivehours at 10:00
Given I implement the first row of the Berlin clock
When the hour for RowFivehours is "10"
Then the following values for RowFivehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | false  | false  |

Scenario: RowFivehours at 11:00
Given I implement the first row of the Berlin clock
When the hour for RowFivehours is "11"
Then the following values for RowFivehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | false  | false  |

Scenario: RowFivehours at 12:00
Given I implement the first row of the Berlin clock
When the hour for RowFivehours is "12"
Then the following values for RowFivehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | false  | false  |

Scenario: RowFivehours at 13:00
Given I implement the first row of the Berlin clock
When the hour for RowFivehours is "13"
Then the following values for RowFivehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | false  | false  |

Scenario: RowFivehours at 14:00
Given I implement the first row of the Berlin clock
When the hour for RowFivehours is "14"
Then the following values for RowFivehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | false  | false  |


Scenario: RowFivehours at 15:00
Given I implement the first row of the Berlin clock
When the hour for RowFivehours is "15"
Then the following values for RowFivehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | true  | false  |

Scenario: RowFivehours at 16:00
Given I implement the first row of the Berlin clock
When the hour for RowFivehours is "16"
Then the following values for RowFivehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | true  | false  |

Scenario: RowFivehours at 17:00
Given I implement the first row of the Berlin clock
When the hour for RowFivehours is "17"
Then the following values for RowFivehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | true  | false  |

Scenario: RowFivehours at 18:00
Given I implement the first row of the Berlin clock
When the hour for RowFivehours is "18"
Then the following values for RowFivehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | true  | false  |

Scenario: RowFivehours at 19:00
Given I implement the first row of the Berlin clock
When the hour for RowFivehours is "19"
Then the following values for RowFivehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | true  | false  |


Scenario: RowFivehours at 20:00
Given I implement the first row of the Berlin clock
When the hour for RowFivehours is "20"
Then the following values for RowFivehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | true  | true  |

Scenario: RowFivehours at 21:00
Given I implement the first row of the Berlin clock
When the hour for RowFivehours is "21"
Then the following values for RowFivehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | true  | true  |

Scenario: RowFivehours at 22:00
Given I implement the first row of the Berlin clock
When the hour for RowFivehours is "22"
Then the following values for RowFivehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | true  | true  |

Scenario: RowFivehours at 23:00
Given I implement the first row of the Berlin clock
When the hour for RowFivehours is "23"
Then the following values for RowFivehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | true  | true  |

Scenario: RowFivehours at 24:00
Given I implement the first row of the Berlin clock
When the hour for RowFivehours is "24"
Then the following values for RowFivehours are valid
    | Light1 | Light2 | Light3 | Light4 |
    | true  | true  | true  | true  |