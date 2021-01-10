using System.Collections.Generic;
using System.Linq;
using eGonullu.Models;

namespace eGonullu.Data
{
	public class CityStateData
	{
		private static List<City> cities = new()
		{
			new()
			{
				Name = "Adana",
				States = new List<string>
				{
					"Aladağ",
					"Ceyhan",
					"Çukurova",
					"Feke",
					"İmamoğlu",
					"Karaisalı",
					"Karataş",
					"Kozan",
					"Pozantı",
					"Saimbeyli",
					"Sarıçam",
					"Seyhan",
					"Tufanbeyli",
					"Yumurtalık",
					"Yüreğir"
				}
			},
			new()
			{
				Name = "Adıyaman",
				States = new List<string>
				{
					"Besni",
					"Çelikhan",
					"Gerger",
					"Gölbaşı",
					"Kahta",
					"Merkez",
					"Samsat",
					"Sincik",
					"Tut"
				}
			},
			new()
			{
				Name = "Afyonkarahisar",
				States = new List<string>
				{
					"Başmakçı",
					"Bayat",
					"Bolvadin",
					"Çay",
					"Çobanlar",
					"Dazkırı",
					"Dinar",
					"Emirdağ",
					"Evciler",
					"Hocalar",
					"İhsaniye",
					"İscehisar",
					"Kızılören",
					"Merkez",
					"Sandıklı",
					"Sinanpaşa",
					"Sultandağı",
					"Şuhut"
				}
			},
			new()
			{
				Name = "Ağrı",
				States = new List<string>
				{
					"Diyadin",
					"Doğubayazıt",
					"Eleşkirt",
					"Hamur",
					"Merkez",
					"Patnos",
					"Taşlıçay",
					"Tutak"
				}
			},
			new()
			{
				Name = "Amasya",
				States = new List<string>
				{
					"Göynücek",
					"Gümüşhacıköy",
					"Hamamözü",
					"Merkez",
					"Merzifon",
					"Suluova",
					"Taşova"
				}
			},
			new()
			{
				Name = "Ankara",
				States = new List<string>
				{
					"Altındağ",
					"Ayaş",
					"Bala",
					"Beypazarı",
					"Çamlıdere",
					"Çankaya",
					"Çubuk",
					"Elmadağ",
					"Güdül",
					"Haymana",
					"Kalecik",
					"Kızılcahamam",
					"Nallıhan",
					"Polatlı",
					"Şereflikoçhisar",
					"Yenimahalle",
					"Gölbaşı",
					"Keçiören",
					"Mamak",
					"Sincan",
					"Kazan",
					"Akyurt",
					"Etimesgut",
					"Evren",
					"Pursaklar"
				}
			},
			new()
			{
				Name = "Antalya",
				States = new List<string>
				{
					"Akseki",
					"Alanya",
					"Elmalı",
					"Finike",
					"Gazipaşa",
					"Gündoğmuş",
					"Kaş",
					"Korkuteli",
					"Kumluca",
					"Manavgat",
					"Serik",
					"Demre",
					"İbradı",
					"Kemer",
					"Aksu",
					"Döşemealtı",
					"Kepez",
					"Konyaaltı",
					"Muratpaşa"
				}
			},
			new()
			{
				Name = "Artvin",
				States = new List<string>
				{
					"Ardanuç",
					"Arhavi",
					"Merkez",
					"Borçka",
					"Hopa",
					"Şavşat",
					"Yusufeli",
					"Murgul"
				}
			},
			new()
			{
				Name = "Aydın",
				States = new List<string>
				{
					"Merkez",
					"Bozdoğan",
					"Efeler",
					"Çine",
					"Germencik",
					"Karacasu",
					"Koçarlı",
					"Kuşadası",
					"Kuyucak",
					"Nazilli",
					"Söke",
					"Sultanhisar",
					"Yenipazar",
					"Buharkent",
					"İncirliova",
					"Karpuzlu",
					"Köşk",
					"Didim"
				}
			},
			new()
			{
				Name = "Balıkesir",
				States = new List<string>
				{
					"Altıeylül",
					"Ayvalık",
					"Merkez",
					"Balya",
					"Bandırma",
					"Bigadiç",
					"Burhaniye",
					"Dursunbey",
					"Edremit",
					"Erdek",
					"Gönen",
					"Havran",
					"İvrindi",
					"Karesi",
					"Kepsut",
					"Manyas",
					"Savaştepe",
					"Sındırgı",
					"Gömeç",
					"Susurluk",
					"Marmara"
				}
			},
			new()
			{
				Name = "Bilecik",
				States = new List<string>
				{
					"Merkez",
					"Bozüyük",
					"Gölpazarı",
					"Osmaneli",
					"Pazaryeri",
					"Söğüt",
					"Yenipazar",
					"İnhisar"
				}
			},
			new()
			{
				Name = "Bingöl",
				States = new List<string>
				{
					"Merkez",
					"Genç",
					"Karlıova",
					"Kiğı",
					"Solhan",
					"Adaklı",
					"Yayladere",
					"Yedisu"
				}
			},
			new()
			{
				Name = "Bitlis",
				States = new List<string>
				{
					"Adilcevaz",
					"Ahlat",
					"Merkez",
					"Hizan",
					"Mutki",
					"Tatvan",
					"Güroymak"
				}
			},
			new()
			{
				Name = "Bolu",
				States = new List<string>
				{
					"Merkez",
					"Gerede",
					"Göynük",
					"Kıbrıscık",
					"Mengen",
					"Mudurnu",
					"Seben",
					"Dörtdivan",
					"Yeniçağa"
				}
			},
			new()
			{
				Name = "Burdur",
				States = new List<string>
				{
					"Ağlasun",
					"Bucak",
					"Merkez",
					"Gölhisar",
					"Tefenni",
					"Yeşilova",
					"Karamanlı",
					"Kemer",
					"Altınyayla",
					"Çavdır",
					"Çeltikçi"
				}
			},
			new()
			{
				Name = "Bursa",
				States = new List<string>
				{
					"Gemlik",
					"İnegöl",
					"İznik",
					"Karacabey",
					"Keles",
					"Mudanya",
					"Mustafakemalpaşa",
					"Orhaneli",
					"Orhangazi",
					"Yenişehir",
					"Büyükorhan",
					"Harmancık",
					"Nilüfer",
					"Osmangazi",
					"Yıldırım",
					"Gürsu",
					"Kestel"
				}
			},
			new()
			{
				Name = "Çanakkale",
				States = new List<string>
				{
					"Ayvacık",
					"Bayramiç",
					"Biga",
					"Bozcaada",
					"Çan",
					"Merkez",
					"Eceabat",
					"Ezine",
					"Gelibolu",
					"Gökçeada",
					"Lapseki",
					"Yenice"
				}
			},
			new()
			{
				Name = "Çankırı",
				States = new List<string>
				{
					"Merkez",
					"Çerkeş",
					"Eldivan",
					"Ilgaz",
					"Kurşunlu",
					"Orta",
					"Şabanözü",
					"Yapraklı",
					"Atkaracalar",
					"Kızılırmak",
					"Bayramören",
					"Korgun"
				}
			},
			new()
			{
				Name = "Çorum",
				States = new List<string>
				{
					"Alaca",
					"Bayat",
					"Merkez",
					"İskilip",
					"Kargı",
					"Mecitözü",
					"Ortaköy",
					"Osmancık",
					"Sungurlu",
					"Boğazkale",
					"Uğurludağ",
					"Dodurga",
					"Laçin",
					"Oğuzlar"
				}
			},
			new()
			{
				Name = "Denizli",
				States = new List<string>
				{
					"Acıpayam",
					"Buldan",
					"Çal",
					"Çameli",
					"Çardak",
					"Çivril",
					"Merkez",
					"Merkezefendi",
					"Pamukkale",
					"Güney",
					"Kale",
					"Sarayköy",
					"Tavas",
					"Babadağ",
					"Bekilli",
					"Honaz",
					"Serinhisar",
					"Baklan",
					"Beyağaç",
					"Bozkurt"
				}
			},
			new()
			{
				Name = "Diyarbakır",
				States = new List<string>
				{
					"Kocaköy",
					"Çermik",
					"Çınar",
					"Çüngüş",
					"Dicle",
					"Ergani",
					"Hani",
					"Hazro",
					"Kulp",
					"Lice",
					"Silvan",
					"Eğil",
					"Bağlar",
					"Kayapınar",
					"Sur",
					"Yenişehir",
					"Bismil"
				}
			},
			new()
			{
				Name = "Edirne",
				States = new List<string>
				{
					"Merkez",
					"Enez",
					"Havsa",
					"İpsala",
					"Keşan",
					"Lalapaşa",
					"Meriç",
					"Uzunköprü",
					"Süloğlu"
				}
			},
			new()
			{
				Name = "Elazığ",
				States = new List<string>
				{
					"Ağın",
					"Baskil",
					"Merkez",
					"Karakoçan",
					"Keban",
					"Maden",
					"Palu",
					"Sivrice",
					"Arıcak",
					"Kovancılar",
					"Alacakaya"
				}
			},
			new()
			{
				Name = "Erzincan",
				States = new List<string>
				{
					"Çayırlı",
					"Merkez",
					"İliç",
					"Kemah",
					"Kemaliye",
					"Refahiye",
					"Tercan",
					"Üzümlü",
					"Otlukbeli"
				}
			},
			new()
			{
				Name = "Erzurum",
				States = new List<string>
				{
					"Aşkale",
					"Çat",
					"Hınıs",
					"Horasan",
					"İspir",
					"Karayazı",
					"Narman",
					"Oltu",
					"Olur",
					"Pasinler",
					"Şenkaya",
					"Tekman",
					"Tortum",
					"Karaçoban",
					"Uzundere",
					"Pazaryolu",
					"Köprüköy",
					"Palandöken",
					"Yakutiye",
					"Aziziye"
				}
			},
			new()
			{
				Name = "Eskişehir",
				States = new List<string>
				{
					"Çifteler",
					"Mahmudiye",
					"Mihalıççık",
					"Sarıcakaya",
					"Seyitgazi",
					"Sivrihisar",
					"Alpu",
					"Beylikova",
					"İnönü",
					"Günyüzü",
					"Han",
					"Mihalgazi",
					"Odunpazarı",
					"Tepebaşı"
				}
			},
			new()
			{
				Name = "Gaziantep",
				States = new List<string>
				{
					"Araban",
					"İslahiye",
					"Nizip",
					"Oğuzeli",
					"Yavuzeli",
					"Şahinbey",
					"Şehitkamil",
					"Karkamış",
					"Nurdağı"
				}
			},
			new()
			{
				Name = "Giresun",
				States = new List<string>
				{
					"Alucra",
					"Bulancak",
					"Dereli",
					"Espiye",
					"Eynesil",
					"Merkez",
					"Görele",
					"Keşap",
					"Şebinkarahisar",
					"Tirebolu",
					"Piraziz",
					"Yağlıdere",
					"Çamoluk",
					"Çanakçı",
					"Doğankent",
					"Güce"
				}
			},
			new()
			{
				Name = "Gümüşhane",
				States = new List<string>
				{
					"Merkez",
					"Kelkit",
					"Şiran",
					"Torul",
					"Köse",
					"Kürtün"
				}
			},
			new()
			{
				Name = "Hakkari",
				States = new List<string>
				{
					"Çukurca",
					"Merkez",
					"Şemdinli",
					"Yüksekova"
				}
			},
			new()
			{
				Name = "Hatay",
				States = new List<string>
				{
					"Altınözü",
					"Arsuz",
					"Defne",
					"Dörtyol",
					"Hassa",
					"Antakya",
					"İskenderun",
					"Kırıkhan",
					"Payas",
					"Reyhanlı",
					"Samandağ",
					"Yayladağı",
					"Erzin",
					"Belen",
					"Kumlu"
				}
			},
			new()
			{
				Name = "Isparta",
				States = new List<string>
				{
					"Atabey",
					"Eğirdir",
					"Gelendost",
					"Merkez",
					"Keçiborlu",
					"Senirkent",
					"Sütçüler",
					"Şarkikaraağaç",
					"Uluborlu",
					"Yalvaç",
					"Aksu",
					"Gönen",
					"Yenişarbademli"
				}
			},
			new()
			{
				Name = "Mersin",
				States = new List<string>
				{
					"Anamur",
					"Erdemli",
					"Gülnar",
					"Mut",
					"Silifke",
					"Tarsus",
					"Aydıncık",
					"Bozyazı",
					"Çamlıyayla",
					"Akdeniz",
					"Mezitli",
					"Toroslar",
					"Yenişehir"
				}
			},
			new()
			{
				Name = "İstanbul",
				States = new List<string>
				{
					"Adalar",
					"Bakırköy",
					"Beşiktaş",
					"Beykoz",
					"Beyoğlu",
					"Çatalca",
					"Eyüp",
					"Fatih",
					"Gaziosmanpaşa",
					"Kadıköy",
					"Kartal",
					"Sarıyer",
					"Silivri",
					"Şile",
					"Şişli",
					"Üsküdar",
					"Zeytinburnu",
					"Büyükçekmece",
					"Kağıthane",
					"Küçükçekmece",
					"Pendik",
					"Ümraniye",
					"Bayrampaşa",
					"Avcılar",
					"Bağcılar",
					"Bahçelievler",
					"Güngören",
					"Maltepe",
					"Sultanbeyli",
					"Tuzla",
					"Esenler",
					"Arnavutköy",
					"Ataşehir",
					"Başakşehir",
					"Beylikdüzü",
					"Çekmeköy",
					"Esenyurt",
					"Sancaktepe",
					"Sultangazi"
				}
			},
			new()
			{
				Name = "İzmir",
				States = new List<string>
				{
					"Aliağa",
					"Bayındır",
					"Bergama",
					"Bornova",
					"Çeşme",
					"Dikili",
					"Foça",
					"Karaburun",
					"Karşıyaka",
					"Kemalpaşa",
					"Kınık",
					"Kiraz",
					"Menemen",
					"Ödemiş",
					"Seferihisar",
					"Selçuk",
					"Tire",
					"Torbalı",
					"Urla",
					"Beydağ",
					"Buca",
					"Konak",
					"Menderes",
					"Balçova",
					"Çiğli",
					"Gaziemir",
					"Narlıdere",
					"Güzelbahçe",
					"Bayraklı",
					"Karabağlar"
				}
			},
			new()
			{
				Name = "Kars",
				States = new List<string>
				{
					"Arpaçay",
					"Digor",
					"Kağızman",
					"Merkez",
					"Sarıkamış",
					"Selim",
					"Susuz",
					"Akyaka"
				}
			},
			new()
			{
				Name = "Kastamonu",
				States = new List<string>
				{
					"Abana",
					"Araç",
					"Azdavay",
					"Bozkurt",
					"Cide",
					"Çatalzeytin",
					"Daday",
					"Devrekani",
					"İnebolu",
					"Merkez",
					"Küre",
					"Taşköprü",
					"Tosya",
					"İhsangazi",
					"Pınarbaşı",
					"Şenpazar",
					"Ağlı",
					"Doğanyurt",
					"Hanönü",
					"Seydiler"
				}
			},
			new()
			{
				Name = "Kayseri",
				States = new List<string>
				{
					"Bünyan",
					"Develi",
					"Felahiye",
					"İncesu",
					"Pınarbaşı",
					"Sarıoğlan",
					"Sarız",
					"Tomarza",
					"Yahyalı",
					"Yeşilhisar",
					"Akkışla",
					"Talas",
					"Kocasinan",
					"Melikgazi",
					"Hacılar",
					"Özvatan"
				}
			},
			new()
			{
				Name = "Kırklareli",
				States = new List<string>
				{
					"Babaeski",
					"Demirköy",
					"Merkez",
					"Kofçaz",
					"Lüleburgaz",
					"Pehlivanköy",
					"Pınarhisar",
					"Vize"
				}
			},
			new()
			{
				Name = "Kırşehir",
				States = new List<string>
				{
					"Çiçekdağı",
					"Kaman",
					"Merkez",
					"Mucur",
					"Akpınar",
					"Akçakent",
					"Boztepe"
				}
			},
			new()
			{
				Name = "Kocaeli",
				States = new List<string>
				{
					"Gebze",
					"Gölcük",
					"Kandıra",
					"Karamürsel",
					"Körfez",
					"Derince",
					"Başiskele",
					"Çayırova",
					"Darıca",
					"Dilovası",
					"İzmit",
					"Kartepe"
				}
			},
			new()
			{
				Name = "Konya",
				States = new List<string>
				{
					"Akşehir",
					"Beyşehir",
					"Bozkır",
					"Cihanbeyli",
					"Çumra",
					"Doğanhisar",
					"Ereğli",
					"Hadim",
					"Ilgın",
					"Kadınhanı",
					"Karapınar",
					"Kulu",
					"Sarayönü",
					"Seydişehir",
					"Yunak",
					"Akören",
					"Altınekin",
					"Derebucak",
					"Hüyük",
					"Karatay",
					"Meram",
					"Selçuklu",
					"Taşkent",
					"Ahırlı",
					"Çeltik",
					"Derbent",
					"Emirgazi",
					"Güneysınır",
					"Halkapınar",
					"Tuzlukçu",
					"Yalıhüyük"
				}
			},
			new()
			{
				Name = "Kütahya",
				States = new List<string>
				{
					"Altıntaş",
					"Domaniç",
					"Emet",
					"Gediz",
					"Merkez",
					"Simav",
					"Tavşanlı",
					"Aslanapa",
					"Dumlupınar",
					"Hisarcık",
					"Şaphane",
					"Çavdarhisar",
					"Pazarlar"
				}
			},
			new()
			{
				Name = "Malatya",
				States = new List<string>
				{
					"Akçadağ",
					"Arapgir",
					"Arguvan",
					"Darende",
					"Doğanşehir",
					"Hekimhan",
					"Merkez",
					"Pütürge",
					"Yeşilyurt",
					"Battalgazi",
					"Doğanyol",
					"Kale",
					"Kuluncak",
					"Yazıhan"
				}
			},
			new()
			{
				Name = "Manisa",
				States = new List<string>
				{
					"Akhisar",
					"Alaşehir",
					"Demirci",
					"Gördes",
					"Kırkağaç",
					"Kula",
					"Merkez",
					"Salihli",
					"Sarıgöl",
					"Saruhanlı",
					"Selendi",
					"Soma",
					"Şehzadeler",
					"Yunusemre",
					"Turgutlu",
					"Ahmetli",
					"Gölmarmara",
					"Köprübaşı"
				}
			},
			new()
			{
				Name = "Kahramanmaraş",
				States = new List<string>
				{
					"Afşin",
					"Andırın",
					"Dulkadiroğlu",
					"Onikişubat",
					"Elbistan",
					"Göksun",
					"Merkez",
					"Pazarcık",
					"Türkoğlu",
					"Çağlayancerit",
					"Ekinözü",
					"Nurhak"
				}
			},
			new()
			{
				Name = "Mardin",
				States = new List<string>
				{
					"Derik",
					"Kızıltepe",
					"Artuklu",
					"Merkez",
					"Mazıdağı",
					"Midyat",
					"Nusaybin",
					"Ömerli",
					"Savur",
					"Dargeçit",
					"Yeşilli"
				}
			},
			new()
			{
				Name = "Muğla",
				States = new List<string>
				{
					"Bodrum",
					"Datça",
					"Fethiye",
					"Köyceğiz",
					"Marmaris",
					"Menteşe",
					"Milas",
					"Ula",
					"Yatağan",
					"Dalaman",
					"Seydikemer",
					"Ortaca",
					"Kavaklıdere"
				}
			},
			new()
			{
				Name = "Muş",
				States = new List<string>
				{
					"Bulanık",
					"Malazgirt",
					"Merkez",
					"Varto",
					"Hasköy",
					"Korkut"
				}
			},
			new()
			{
				Name = "Nevşehir",
				States = new List<string>
				{
					"Avanos",
					"Derinkuyu",
					"Gülşehir",
					"Hacıbektaş",
					"Kozaklı",
					"Merkez",
					"Ürgüp",
					"Acıgöl"
				}
			},
			new()
			{
				Name = "Niğde",
				States = new List<string>
				{
					"Bor",
					"Çamardı",
					"Merkez",
					"Ulukışla",
					"Altunhisar",
					"Çiftlik"
				}
			},
			new()
			{
				Name = "Ordu",
				States = new List<string>
				{
					"Akkuş",
					"Altınordu",
					"Aybastı",
					"Fatsa",
					"Gölköy",
					"Korgan",
					"Kumru",
					"Mesudiye",
					"Perşembe",
					"Ulubey",
					"Ünye",
					"Gülyalı",
					"Gürgentepe",
					"Çamaş",
					"Çatalpınar",
					"Çaybaşı",
					"İkizce",
					"Kabadüz",
					"Kabataş"
				}
			},
			new()
			{
				Name = "Rize",
				States = new List<string>
				{
					"Ardeşen",
					"Çamlıhemşin",
					"Çayeli",
					"Fındıklı",
					"İkizdere",
					"Kalkandere",
					"Pazar",
					"Merkez",
					"Güneysu",
					"Derepazarı",
					"Hemşin",
					"İyidere"
				}
			},
			new()
			{
				Name = "Sakarya",
				States = new List<string>
				{
					"Akyazı",
					"Geyve",
					"Hendek",
					"Karasu",
					"Kaynarca",
					"Sapanca",
					"Kocaali",
					"Pamukova",
					"Taraklı",
					"Ferizli",
					"Karapürçek",
					"Söğütlü",
					"Adapazarı",
					"Arifiye",
					"Erenler",
					"Serdivan"
				}
			},
			new()
			{
				Name = "Samsun",
				States = new List<string>
				{
					"Alaçam",
					"Bafra",
					"Çarşamba",
					"Havza",
					"Kavak",
					"Ladik",
					"Terme",
					"Vezirköprü",
					"Asarcık",
					"Ondokuzmayıs",
					"Salıpazarı",
					"Tekkeköy",
					"Ayvacık",
					"Yakakent",
					"Atakum",
					"Canik",
					"İlkadım"
				}
			},
			new()
			{
				Name = "Siirt",
				States = new List<string>
				{
					"Baykan",
					"Eruh",
					"Kurtalan",
					"Pervari",
					"Merkez",
					"Şirvan",
					"Tillo"
				}
			},
			new()
			{
				Name = "Sinop",
				States = new List<string>
				{
					"Ayancık",
					"Boyabat",
					"Durağan",
					"Erfelek",
					"Gerze",
					"Merkez",
					"Türkeli",
					"Dikmen",
					"Saraydüzü"
				}
			},
			new()
			{
				Name = "Sivas",
				States = new List<string>
				{
					"Divriği",
					"Gemerek",
					"Gürün",
					"Hafik",
					"İmranlı",
					"Kangal",
					"Koyulhisar",
					"Merkez",
					"Suşehri",
					"Şarkışla",
					"Yıldızeli",
					"Zara",
					"Akıncılar",
					"Altınyayla",
					"Doğanşar",
					"Gölova",
					"Ulaş"
				}
			},
			new()
			{
				Name = "Tekirdağ",
				States = new List<string>
				{
					"Çerkezköy",
					"Çorlu",
					"Ergene",
					"Hayrabolu",
					"Malkara",
					"Muratlı",
					"Saray",
					"Süleymanpaşa",
					"Kapaklı",
					"Şarköy",
					"Marmaraereğlisi"
				}
			},
			new()
			{
				Name = "Tokat",
				States = new List<string>
				{
					"Almus",
					"Artova",
					"Erbaa",
					"Niksar",
					"Reşadiye",
					"Merkez",
					"Turhal",
					"Zile",
					"Pazar",
					"Yeşilyurt",
					"Başçiftlik",
					"Sulusaray"
				}
			},
			new()
			{
				Name = "Trabzon",
				States = new List<string>
				{
					"Akçaabat",
					"Araklı",
					"Arsin",
					"Çaykara",
					"Maçka",
					"Of",
					"Ortahisar",
					"Sürmene",
					"Tonya",
					"Vakfıkebir",
					"Yomra",
					"Beşikdüzü",
					"Şalpazarı",
					"Çarşıbaşı",
					"Dernekpazarı",
					"Düzköy",
					"Hayrat",
					"Köprübaşı"
				}
			},
			new()
			{
				Name = "Tunceli",
				States = new List<string>
				{
					"Çemişgezek",
					"Hozat",
					"Mazgirt",
					"Nazımiye",
					"Ovacık",
					"Pertek",
					"Pülümür",
					"Merkez"
				}
			},
			new()
			{
				Name = "Şanlıurfa",
				States = new List<string>
				{
					"Akçakale",
					"Birecik",
					"Bozova",
					"Ceylanpınar",
					"Eyyübiye",
					"Halfeti",
					"Haliliye",
					"Hilvan",
					"Karaköprü",
					"Siverek",
					"Suruç",
					"Viranşehir",
					"Harran"
				}
			},
			new()
			{
				Name = "Uşak",
				States = new List<string>
				{
					"Banaz",
					"Eşme",
					"Karahallı",
					"Sivaslı",
					"Ulubey",
					"Merkez"
				}
			},
			new()
			{
				Name = "Van",
				States = new List<string>
				{
					"Başkale",
					"Çatak",
					"Erciş",
					"Gevaş",
					"Gürpınar",
					"İpekyolu",
					"Muradiye",
					"Özalp",
					"Tuşba",
					"Bahçesaray",
					"Çaldıran",
					"Edremit",
					"Saray"
				}
			},
			new()
			{
				Name = "Yozgat",
				States = new List<string>
				{
					"Akdağmadeni",
					"Boğazlıyan",
					"Çayıralan",
					"Çekerek",
					"Sarıkaya",
					"Sorgun",
					"Şefaatli",
					"Yerköy",
					"Merkez",
					"Aydıncık",
					"Çandır",
					"Kadışehri",
					"Saraykent",
					"Yenifakılı"
				}
			},
			new()
			{
				Name = "Zonguldak",
				States = new List<string>
				{
					"Çaycuma",
					"Devrek",
					"Ereğli",
					"Merkez",
					"Alaplı",
					"Gökçebey"
				}
			},
			new()
			{
				Name = "Aksaray",
				States = new List<string>
				{
					"Ağaçören",
					"Eskil",
					"Gülağaç",
					"Güzelyurt",
					"Merkez",
					"Ortaköy",
					"Sarıyahşi"
				}
			},
			new()
			{
				Name = "Bayburt",
				States = new List<string>
				{
					"Merkez",
					"Aydıntepe",
					"Demirözü"
				}
			},
			new()
			{
				Name = "Karaman",
				States = new List<string>
				{
					"Ermenek",
					"Merkez",
					"Ayrancı",
					"Kazımkarabekir",
					"Başyayla",
					"Sarıveliler"
				}
			},
			new()
			{
				Name = "Kırıkkale",
				States = new List<string>
				{
					"Delice",
					"Keskin",
					"Merkez",
					"Sulakyurt",
					"Bahşili",
					"Balışeyh",
					"Çelebi",
					"Karakeçili",
					"Yahşihan"
				}
			},
			new()
			{
				Name = "Batman",
				States = new List<string>
				{
					"Merkez",
					"Beşiri",
					"Gercüş",
					"Kozluk",
					"Sason",
					"Hasankeyf"
				}
			},
			new()
			{
				Name = "Şırnak",
				States = new List<string>
				{
					"Beytüşşebap",
					"Cizre",
					"İdil",
					"Silopi",
					"Merkez",
					"Uludere",
					"Güçlükonak"
				}
			},
			new()
			{
				Name = "Bartın",
				States = new List<string>
				{
					"Merkez",
					"Kurucaşile",
					"Ulus",
					"Amasra"
				}
			},
			new()
			{
				Name = "Ardahan",
				States = new List<string>
				{
					"Merkez",
					"Çıldır",
					"Göle",
					"Hanak",
					"Posof",
					"Damal"
				}
			},
			new()
			{
				Name = "Iğdır",
				States = new List<string>
				{
					"Aralık",
					"Merkez",
					"Tuzluca",
					"Karakoyunlu"
				}
			},
			new()
			{
				Name = "Yalova",
				States = new List<string>
				{
					"Merkez",
					"Altınova",
					"Armutlu",
					"Çınarcık",
					"Çiftlikköy",
					"Termal"
				}
			},
			new()
			{
				Name = "Karabük",
				States = new List<string>
				{
					"Eflani",
					"Eskipazar",
					"Merkez",
					"Ovacık",
					"Safranbolu",
					"Yenice"
				}
			},
			new()
			{
				Name = "Kilis",
				States = new List<string>
				{
					"Merkez",
					"Elbeyli",
					"Musabeyli",
					"Polateli"
				}
			},
			new()
			{
				Name = "Osmaniye",
				States = new List<string>
				{
					"Bahçe",
					"Kadirli",
					"Merkez",
					"Düziçi",
					"Hasanbeyli",
					"Sumbas",
					"Toprakkale"
				}
			},
			new()
			{
				Name = "Düzce",
				States = new List<string>
				{
					"Akçakoca",
					"Merkez",
					"Yığılca",
					"Cumayeri",
					"Gölyaka",
					"Çilimli",
					"Gümüşova",
					"Kaynaşlı"
				}
			}
		};

		public static List<string> GetCities()
		{
			return cities.ConvertAll<string>(c => c.Name);
		}

		public static List<string> GetStates(string city)
		{
			if (city == null) return new List<string>{ "Hepsi" };
			return cities.SingleOrDefault(c => c.Name == city).States;
		}
	}
}