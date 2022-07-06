/*
 * ISO 3166-1 country codes
 *
 * Last check against the official ISO 3166 as on https://www.iso.org/obp/ui/#search: 8th January 2020.
 */

namespace Experiment.Data.Data
{
    public class Country
    {
        private Country(string name, string twoLetterCode, string threeLetterCode, string numericCode)
        {
            Name = name;
            TwoLetterCode = twoLetterCode;
            ThreeLetterCode = threeLetterCode;
            NumericCode = numericCode;
        }

        public static readonly Country[] List = new[]
        {
            new Country("Afghanistan", "AF", "AFG", "004"),
            new Country("Albania", "AL", "ALB", "008"),
            new Country("Algeria", "DZ", "DZA", "012"),
            new Country("American Samoa", "AS", "ASM", "016"),
            new Country("Andorra", "AD", "AND", "020"),
            new Country("Angola", "AO", "AGO", "024"),
            new Country("Anguilla", "AI", "AIA", "660"),
            new Country("Antarctica", "AQ", "ATA", "010"),
            new Country("Antigua and Barbuda", "AG", "ATG", "028"),
            new Country("Argentina", "AR", "ARG", "032"),
            new Country("Armenia", "AM", "ARM", "051"),
            new Country("Aruba", "AW", "ABW", "533"),
            new Country("Australia", "AU", "AUS", "036"),
            new Country("Austria", "AT", "AUT", "040"),
            new Country("Azerbaijan", "AZ", "AZE", "031"),
            new Country("Tonga", "TO", "TON", "776"),
            new Country("Trinidad and Tobago", "TT", "TTO", "780"),
            new Country("Tunisia", "TN", "TUN", "788"),
            new Country("Turkey", "TR", "TUR", "792"),
            new Country("Turkmenistan", "TM", "TKM", "795"),
            new Country("Turks and Caicos Islands", "TC", "TCA", "796"),
            new Country("Tuvalu", "TV", "TUV", "798"),
            new Country("Uganda", "UG", "UGA", "800"),
            new Country("Ukraine", "UA", "UKR", "804"),
            new Country("United Arab Emirates", "AE", "ARE", "784"),
            new Country("United Kingdom of Great Britain and Northern Ireland", "GB", "GBR", "826"),
            new Country("United States of America", "US", "USA", "840"),
            new Country("United States Minor Outlying Islands", "UM", "UMI", "581"),
            new Country("Uruguay", "UY", "URY", "858"),
            new Country("Uzbekistan", "UZ", "UZB", "860"),
            new Country("Vanuatu", "VU", "VUT", "548"),
            new Country("Venezuela, Bolivarian Republic of", "VE", "VEN", "862"),
            new Country("Viet Nam", "VN", "VNM", "704"),
            new Country("Virgin Islands, British", "VG", "VGB", "092"),
            new Country("Virgin Islands, U.S.", "VI", "VIR", "850"),
            new Country("Wallis and Futuna", "WF", "WLF", "876"),
            new Country("Western Sahara", "EH", "ESH", "732"),
            new Country("Yemen", "YE", "YEM", "887"),
            new Country("Zambia", "ZM", "ZMB", "894"),
            new Country("Zimbabwe", "ZW", "ZWE", "716"),
            new Country("Åland Islands", "AX", "ALA", "248")
        };

        public string Name { get; private set; }
        public string NumericCode { get; private set; }
        public string ThreeLetterCode { get; private set; }
        public string TwoLetterCode { get; private set; }
    }
}