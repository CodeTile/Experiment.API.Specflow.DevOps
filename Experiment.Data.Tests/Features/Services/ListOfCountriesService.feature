Feature: ListOfCountriesService

Scenario: ListOfCountriesService_GetAsync
	Given I initiate the service ListOfCountriesService
	When I call the method GetAllAsync
	Then the result is a list with the values
		| Expected                                             |
		| Afghanistan                                          |
		| Åland Islands                                        |
		| Albania                                              |
		| Algeria                                              |
		| American Samoa                                       |
		| Andorra                                              |
		| Angola                                               |
		| Anguilla                                             |
		| Antarctica                                           |
		| Antigua and Barbuda                                  |
		| Argentina                                            |
		| Armenia                                              |
		| Aruba                                                |
		| Australia                                            |
		| Austria                                              |
		| Azerbaijan                                           |
		| Tonga                                                |
		| Trinidad and Tobago                                  |
		| Tunisia                                              |
		| Turkey                                               |
		| Turkmenistan                                         |
		| Turks and Caicos Islands                             |
		| Tuvalu                                               |
		| Uganda                                               |
		| Ukraine                                              |
		| United Arab Emirates                                 |
		| United Kingdom of Great Britain and Northern Ireland |
		| United States Minor Outlying Islands                 |
		| United States of America                             |
		| Uruguay                                              |
		| Uzbekistan                                           |
		| Vanuatu                                              |
		| Venezuela, Bolivarian Republic of                    |
		| Viet Nam                                             |
		| Virgin Islands, British                              |
		| Virgin Islands, U.S.                                 |
		| Wallis and Futuna                                    |
		| Western Sahara                                       |
		| Yemen                                                |
		| Zambia                                               |
		| Zimbabwe                                             |

