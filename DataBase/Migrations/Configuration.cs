namespace DataBase.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using KaloriDeneme_1111.ModelCluster;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;


    internal sealed class Configuration : DbMigrationsConfiguration<KaloriDeneme_1111.DataBase.KaloriDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(KaloriDeneme_1111.DataBase.KaloriDbContext context)
        {



            NutrientCategory sütÜrünleri = new NutrientCategory() { NutrientCategoryName = "Süt ve Süt Ürünleri" };
            NutrientCategory yağlar = new NutrientCategory() { NutrientCategoryName = "Yağlar" };
            NutrientCategory etÜrünleriveYumurta = new NutrientCategory() { NutrientCategoryName = "Et, Et Ürünleri ve Yumurta" };
            NutrientCategory bakliyat = new NutrientCategory() { NutrientCategoryName = "Bakliyat" };
            NutrientCategory tahıl = new NutrientCategory() { NutrientCategoryName = "Tahıl ve Ekmek Grubu" };
            NutrientCategory sebzeGrubu = new NutrientCategory() { NutrientCategoryName = "Sebze Grubu" };
            NutrientCategory çorbalar = new NutrientCategory() { NutrientCategoryName = "Çorbalar" };
            NutrientCategory meyveGrubu = new NutrientCategory() { NutrientCategoryName = "Meyve Grubu" };
            NutrientCategory tatlılar = new NutrientCategory() { NutrientCategoryName = "Tatlılar" };
            NutrientCategory sağlıklıAtıştırmalıklar = new NutrientCategory() { NutrientCategoryName = "Sağlıklı Atıştırmalıklar" };
            NutrientCategory sağlıksızAtıştırmalıklar = new NutrientCategory() { NutrientCategoryName = "Sağlıksız Atıştırmalıklar" };
            NutrientCategory çeşniler = new NutrientCategory() { NutrientCategoryName = "Çeşniler" };
            NutrientCategory içecekler = new NutrientCategory() { NutrientCategoryName = "İçecekler" };
            NutrientCategory yağlıTohumlar = new NutrientCategory() { NutrientCategoryName = "YağlıTohumlar" };
            NutrientCategory tahılveSebzeGrubu = new NutrientCategory() { NutrientCategoryName = "TahılveSebzeYemekleri" };
            NutrientCategory etveSebzeGrubu = new NutrientCategory() { NutrientCategoryName = "EtveSebzeYemekleri" };
            NutrientCategory etveTahılGrubu = new NutrientCategory() { NutrientCategoryName = "EtveTahılYemekleri" };
            NutrientCategory etveBakliyatGrubu = new NutrientCategory() { NutrientCategoryName = "EtveBakliyatYemekleri" };

            context.NutrientCategories.Add(sütÜrünleri);
            context.NutrientCategories.Add(etÜrünleriveYumurta);
            context.NutrientCategories.Add(bakliyat);
            context.NutrientCategories.Add(sebzeGrubu);
            context.NutrientCategories.Add(meyveGrubu);
            context.NutrientCategories.Add(tatlılar);
            context.NutrientCategories.Add(sağlıklıAtıştırmalıklar);
            context.NutrientCategories.Add(sağlıksızAtıştırmalıklar);
            context.NutrientCategories.Add(çeşniler);
            context.NutrientCategories.Add(yağlar);
            context.NutrientCategories.Add(çorbalar);
            context.NutrientCategories.Add(tahıl);
            context.NutrientCategories.Add(içecekler);
            context.NutrientCategories.Add(yağlıTohumlar);
            context.NutrientCategories.Add(tahılveSebzeGrubu);
            context.NutrientCategories.Add(etveSebzeGrubu);
            context.NutrientCategories.Add(etveTahılGrubu);
            context.NutrientCategories.Add(etveBakliyatGrubu);


            //AV HAYVANLARI
            Nutrient bıldırcınEti = new Nutrient() { NutrientName = "Bıldırcın Eti", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 192 }, new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 230 }, } };
            context.Nutrients.Add(bıldırcınEti);

            Nutrient güvercineti = new Nutrient() { NutrientName = "Güvercin Eti", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 294 }, new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 192 }, } };
            context.Nutrients.Add(güvercineti);

            Nutrient sülün = new Nutrient() { NutrientName = "Sülün Eti", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 181 }, new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 200 }, } };
            context.Nutrients.Add(sülün);

            Nutrient tavşan = new Nutrient() { NutrientName = "Tavşan Eti", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 162 }, new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 260 }, } };
            context.Nutrients.Add(tavşan);
            //BALIKLAR VE DENİZ ÜRÜNLERİ
            Nutrient alabalık = new Nutrient() { NutrientName = "Alabalık", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 175 }, new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 336 }, } };
            context.Nutrients.Add(alabalık);

            Nutrient kalkan = new Nutrient() { NutrientName = "Kalkan Balığı", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 193 }, new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 143 }, } };
            context.Nutrients.Add(kalkan);

            Nutrient kılıç = new Nutrient() { NutrientName = "Kılıç Balığı", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 164 }, new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 203 }, } };
            context.Nutrients.Add(kılıç);

            Nutrient levrek = new Nutrient() { NutrientName = "Levrek Balığı", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 93 }, new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 291 }, } };
            context.Nutrients.Add(levrek);

            Nutrient mersin = new Nutrient() { NutrientName = "Mersin Balığı", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 96 }, } };
            context.Nutrients.Add(mersin);

            Nutrient palamut = new Nutrient() { NutrientName = "Palamut Balığı", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 168 }, new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 324 }, new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 605 }, } };
            context.Nutrients.Add(palamut);

            Nutrient sardalya = new Nutrient() { NutrientName = "Sardalya Balığı", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 160 }, new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 41 }, } };
            context.Nutrients.Add(sardalya);

            Nutrient somon = new Nutrient() { NutrientName = "Somon Balığı", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 155 }, new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 358 }, } };
            context.Nutrients.Add(somon);

            Nutrient ton = new Nutrient() { NutrientName = "Ton Balığı", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 289 }, new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 206 }, } };
            context.Nutrients.Add(ton);

            Nutrient uskumru = new Nutrient() { NutrientName = "Uskumru Balığı", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 205 }, new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 174 }, } };
            context.Nutrients.Add(uskumru);

            Nutrient havyar = new Nutrient() { NutrientName = "Havyar", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 40 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 264 }, } };
            context.Nutrients.Add(havyar);

            Nutrient istakoz = new Nutrient() { NutrientName = "İstakoz", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 27 }, new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 89 }, } };
            context.Nutrients.Add(istakoz);

            Nutrient istiridye = new Nutrient() { NutrientName = "İstiridye", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 81 } } };
            context.Nutrients.Add(istiridye);

            Nutrient karides = new Nutrient() { NutrientName = "Karides", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 85 }, new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 17 }, } };
            context.Nutrients.Add(karides);

            Nutrient midye = new Nutrient() { NutrientName = "Midye", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 86 }, new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 77 }, } };
            context.Nutrients.Add(midye);

            Nutrient yengeç = new Nutrient() { NutrientName = "Yengeç", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 82 }, new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 123 }, } };
            context.Nutrients.Add(yengeç);

            //ET ÜRÜNLERİ
            Nutrient danaJambon = new Nutrient() { NutrientName = "Dana Jambon", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Dilim, UnitCalorie = 32 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 106 }, } };
            context.Nutrients.Add(danaJambon);

            Nutrient kavurma = new Nutrient() { NutrientName = "Kavurma", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 345 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 345 }, } };
            context.Nutrients.Add(kavurma);

            Nutrient pastırma = new Nutrient() { NutrientName = "Pastırma", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 75 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 250 }, } };
            context.Nutrients.Add(pastırma);

            Nutrient salam = new Nutrient() { NutrientName = "Salam", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 150 }, new Scale() { ScaleType = ScaleTypes.Dilim, UnitCalorie = 75 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 299 } } };
            context.Nutrients.Add(salam);

            Nutrient sosis = new Nutrient() { NutrientName = "Dana Sosis", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 60 }, new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 60 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 150 } } };
            context.Nutrients.Add(sosis);

            Nutrient sucuk = new Nutrient() { NutrientName = "Tam Yağlı Sucuk", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 166 }, new Scale() { ScaleType = ScaleTypes.Dilim, UnitCalorie = 26 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 331 } } };
            context.Nutrients.Add(sucuk);

            //KÜMES HAYVANLARI
            Nutrient hindiEti = new Nutrient() { NutrientName = "Hindi Eti", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 166 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 160 } } };
            context.Nutrients.Add(hindiEti);

            Nutrient kaz = new Nutrient() { NutrientName = "Kaz Eti", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 371 } } };
            context.Nutrients.Add(kaz);

            Nutrient ördek = new Nutrient() { NutrientName = "Ördek Eti", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 339 } } };
            context.Nutrients.Add(ördek);
            Nutrient tavukDerili = new Nutrient() { NutrientName = "Tavuk-Beyaz Et Derili", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 186 } } };
            context.Nutrients.Add(tavukDerili);

            Nutrient tavukDerisiz = new Nutrient() { NutrientName = "Tavuk-Beyaz Et Derisiz", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 114 } } };
            context.Nutrients.Add(tavukDerisiz);

            //BİTKİSEL YAĞLAR
            Nutrient ayçiçeği = new Nutrient() { NutrientName = "Ayçiçek Yağı", Quantity = 1, NutrientCategory = yağlar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 884 }, new Scale() { ScaleType = ScaleTypes.MLitre, UnitCalorie = 884 }, new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 1768 }, new Scale() { ScaleType = ScaleTypes.TatlıKaşığı, UnitCalorie = 44 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 88 } } };
            context.Nutrients.Add(ayçiçeği);

            Nutrient fındıkYağı = new Nutrient() { NutrientName = "Fındık Yağı", Quantity = 1, NutrientCategory = yağlar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 884 }, new Scale() { ScaleType = ScaleTypes.MLitre, UnitCalorie = 884 }, new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 1768 }, new Scale() { ScaleType = ScaleTypes.TatlıKaşığı, UnitCalorie = 44 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 88 }, } };
            context.Nutrients.Add(fındıkYağı);

            Nutrient haşhaşYağı = new Nutrient() { NutrientName = "Fındık Yağı", Quantity = 1, NutrientCategory = yağlar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 884 }, new Scale() { ScaleType = ScaleTypes.MLitre, UnitCalorie = 884 }, new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 1768 }, new Scale() { ScaleType = ScaleTypes.TatlıKaşığı, UnitCalorie = 44 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 88 }, } };
            context.Nutrients.Add(haşhaşYağı);

            Nutrient ketenTohumuYağı = new Nutrient() { NutrientName = "Keten Tohumu Yağı", Quantity = 1, NutrientCategory = yağlar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 884 }, new Scale() { ScaleType = ScaleTypes.MLitre, UnitCalorie = 884 }, new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 1768 }, new Scale() { ScaleType = ScaleTypes.TatlıKaşığı, UnitCalorie = 44 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 88 }, } };
            context.Nutrients.Add(ketenTohumuYağı);

            Nutrient mısırÖzüYağı = new Nutrient() { NutrientName = "Mısır Özü Yağı", Quantity = 1, NutrientCategory = yağlar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 884 }, new Scale() { ScaleType = ScaleTypes.MLitre, UnitCalorie = 884 }, new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 1768 }, new Scale() { ScaleType = ScaleTypes.TatlıKaşığı, UnitCalorie = 44 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 88 }, } };
            context.Nutrients.Add(mısırÖzüYağı);

            Nutrient palmiyeYağı = new Nutrient() { NutrientName = "PalmiyeYağı", Quantity = 1, NutrientCategory = yağlar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 884 }, new Scale() { ScaleType = ScaleTypes.MLitre, UnitCalorie = 884 }, new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 1768 }, new Scale() { ScaleType = ScaleTypes.TatlıKaşığı, UnitCalorie = 44 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 88 }, } };
            context.Nutrients.Add(palmiyeYağı);

            Nutrient pamukYağı = new Nutrient() { NutrientName = "Pamuk Yağı", Quantity = 1, NutrientCategory = yağlar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 884 }, new Scale() { ScaleType = ScaleTypes.MLitre, UnitCalorie = 884 }, new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 1768 }, new Scale() { ScaleType = ScaleTypes.TatlıKaşığı, UnitCalorie = 44 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 88 }, } };
            context.Nutrients.Add(pamukYağı);

            Nutrient soyaYağı = new Nutrient() { NutrientName = "Soya Yağı", Quantity = 1, NutrientCategory = yağlar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 884 }, new Scale() { ScaleType = ScaleTypes.MLitre, UnitCalorie = 884 }, new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 1768 }, new Scale() { ScaleType = ScaleTypes.TatlıKaşığı, UnitCalorie = 44 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 88 }, } };
            context.Nutrients.Add(soyaYağı);

            Nutrient susamYağı = new Nutrient() { NutrientName = "Susam Yağı", Quantity = 1, NutrientCategory = yağlar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 884 }, new Scale() { ScaleType = ScaleTypes.MLitre, UnitCalorie = 884 }, new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 1768 }, new Scale() { ScaleType = ScaleTypes.TatlıKaşığı, UnitCalorie = 44 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 88 }, } };
            context.Nutrients.Add(susamYağı);

            Nutrient yerFıstığıYağı = new Nutrient() { NutrientName = "Yer Fıstığı Yağı", Quantity = 1, NutrientCategory = yağlar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 884 }, new Scale() { ScaleType = ScaleTypes.MLitre, UnitCalorie = 884 }, new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 1768 }, new Scale() { ScaleType = ScaleTypes.TatlıKaşığı, UnitCalorie = 44 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 88 }, } };
            context.Nutrients.Add(yerFıstığıYağı);

            Nutrient zeytinyağı = new Nutrient() { NutrientName = "ZeytinYağı", Quantity = 1, NutrientCategory = yağlar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 884 }, new Scale() { ScaleType = ScaleTypes.MLitre, UnitCalorie = 884 }, new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 1768 }, new Scale() { ScaleType = ScaleTypes.TatlıKaşığı, UnitCalorie = 44 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 88 }, } };
            context.Nutrients.Add(zeytinyağı);

            Nutrient margarin = new Nutrient() { NutrientName = "Margarin Yağı", Quantity = 1, NutrientCategory = yağlar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 720 }, new Scale() { ScaleType = ScaleTypes.MLitre, UnitCalorie = 720 }, new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 1440 }, new Scale() { ScaleType = ScaleTypes.TatlıKaşığı, UnitCalorie = 34.5 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 69 }, } };
            context.Nutrients.Add(margarin);

            //HAYVANSAL YAĞLAR
            Nutrient balıkYağı = new Nutrient() { NutrientName = "Balık Yağı", Quantity = 1, NutrientCategory = yağlar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 900 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 88 } } };
            context.Nutrients.Add(balıkYağı);

            Nutrient içYağı = new Nutrient() { NutrientName = "İçYağı", Quantity = 1, NutrientCategory = yağlar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 758 } } };
            context.Nutrients.Add(içYağı);

            Nutrient kuyrukYağı = new Nutrient() { NutrientName = "Kuyruk Yağı", Quantity = 1, NutrientCategory = yağlar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 902 } } };
            context.Nutrients.Add(kuyrukYağı);

            Nutrient tereyağı = new Nutrient() { NutrientName = "Tereyağı", Quantity = 1, NutrientCategory = yağlar, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 215 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 717 } } };
            context.Nutrients.Add(tereyağı);

            //ÇEŞNİLER
            Nutrient defneyaprağı = new Nutrient() { NutrientName = "Defne Yaprağı", Quantity = 1, NutrientCategory = çeşniler, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 313 } } };
            context.Nutrients.Add(defneyaprağı);

            Nutrient dereotu_k = new Nutrient() { NutrientName = "Kuru Dere Otu", Quantity = 1, NutrientCategory = çeşniler, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 253 } } };
            context.Nutrients.Add(dereotu_k);

            Nutrient hardal_toz = new Nutrient() { NutrientName = "Toz Hardal", Quantity = 1, NutrientCategory = çeşniler, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 469 } } };
            context.Nutrients.Add(hardal_toz);

            Nutrient haşhaş_tohumu = new Nutrient() { NutrientName = "Haşhaş Tohumu", Quantity = 1, NutrientCategory = çeşniler, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 533 } } };
            context.Nutrients.Add(haşhaş_tohumu);

            Nutrient toz_hindistancevizi = new Nutrient() { NutrientName = "Toz Hindistan Cevizi", Quantity = 1, NutrientCategory = çeşniler, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 525 } } };
            context.Nutrients.Add(toz_hindistancevizi);

            Nutrient karabiber = new Nutrient() { NutrientName = "Karabiber", Quantity = 1, NutrientCategory = çeşniler, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 255 } } };
            context.Nutrients.Add(karabiber);

            Nutrient karanfil = new Nutrient() { NutrientName = "Karanfil", Quantity = 1, NutrientCategory = çeşniler, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 323 } } };
            context.Nutrients.Add(karanfil);

            Nutrient kekik = new Nutrient() { NutrientName = "Haşhaş Tohumu", Quantity = 1, NutrientCategory = çeşniler, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 276 } } };
            context.Nutrients.Add(kekik);

            Nutrient toz_kırmızıbiber = new Nutrient() { NutrientName = "Toz Kırmızı Biber", Quantity = 1, NutrientCategory = çeşniler, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 318 } } };
            context.Nutrients.Add(toz_kırmızıbiber);

            Nutrient kimyon = new Nutrient() { NutrientName = "Kimyon", Quantity = 1, NutrientCategory = çeşniler, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 375 } } };
            context.Nutrients.Add(kimyon);

            Nutrient kuşÜzümü = new Nutrient() { NutrientName = "Kuş Üzümü", Quantity = 1, NutrientCategory = çeşniler, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 303 } } };
            context.Nutrients.Add(kuşÜzümü);

            Nutrient kuruMaydonoz = new Nutrient() { NutrientName = "Kuru Maydonoz", Quantity = 1, NutrientCategory = çeşniler, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 276 } } };
            context.Nutrients.Add(kuruMaydonoz);

            Nutrient kuruNane = new Nutrient() { NutrientName = "Kuru Nane", Quantity = 1, NutrientCategory = çeşniler, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 245 } } };
            context.Nutrients.Add(kuruNane);

            Nutrient safran = new Nutrient() { NutrientName = "Safran", Quantity = 1, NutrientCategory = çeşniler, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 310 } } };
            context.Nutrients.Add(safran);

            Nutrient tarçın = new Nutrient() { NutrientName = "Tarçın", Quantity = 1, NutrientCategory = çeşniler, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 261 } } };
            context.Nutrients.Add(tarçın);

            Nutrient zencefil = new Nutrient() { NutrientName = "Zencefil", Quantity = 1, NutrientCategory = çeşniler, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 347 } } };
            context.Nutrients.Add(zencefil);

            //ÇORBALAR
            Nutrient bezelyeÇorbası = new Nutrient() { NutrientName = "Bezelye Çorbası", Quantity = 1, NutrientCategory = çorbalar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 20 }, new Scale() { ScaleType = ScaleTypes.Kase, UnitCalorie = 41 } } };
            context.Nutrients.Add(bezelyeÇorbası);

            Nutrient domatesÇorbası = new Nutrient() { NutrientName = "Domates Çorbası", Quantity = 1, NutrientCategory = çorbalar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 32 }, new Scale() { ScaleType = ScaleTypes.Kase, UnitCalorie = 66 } } };
            context.Nutrients.Add(domatesÇorbası);

            Nutrient ezogelinÇorbası = new Nutrient() { NutrientName = "Ezogelin Çorbası", Quantity = 1, NutrientCategory = çorbalar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 45 }, new Scale() { ScaleType = ScaleTypes.Kase, UnitCalorie = 95 } } };
            context.Nutrients.Add(ezogelinÇorbası);

            Nutrient işkembeÇorbası = new Nutrient() { NutrientName = "İşkembe Çorbası", Quantity = 1, NutrientCategory = çorbalar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 139 }, new Scale() { ScaleType = ScaleTypes.Kase, UnitCalorie = 209 } } };
            context.Nutrients.Add(işkembeÇorbası);

            Nutrient mercimekÇorbası = new Nutrient() { NutrientName = "Bezelye Çorbası", Quantity = 1, NutrientCategory = çorbalar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 46 }, new Scale() { ScaleType = ScaleTypes.Kase, UnitCalorie = 137 } } };
            context.Nutrients.Add(mercimekÇorbası);

            Nutrient sebzeÇorbası = new Nutrient() { NutrientName = "Sebze Çorbası", Quantity = 1, NutrientCategory = çorbalar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 44 }, new Scale() { ScaleType = ScaleTypes.Kase, UnitCalorie = 114 } } };
            context.Nutrients.Add(sebzeÇorbası);

            Nutrient tarhanaÇorbası = new Nutrient() { NutrientName = "Tarhana Çorbası", Quantity = 1, NutrientCategory = çorbalar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 60 }, new Scale() { ScaleType = ScaleTypes.Kase, UnitCalorie = 151 } } };
            context.Nutrients.Add(tarhanaÇorbası);

            Nutrient yaylaÇorbası = new Nutrient() { NutrientName = "Yayla Çorbası", Quantity = 1, NutrientCategory = çorbalar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 47 }, new Scale() { ScaleType = ScaleTypes.Kase, UnitCalorie = 98 } } };
            context.Nutrients.Add(yaylaÇorbası);

            Nutrient yulafÖzüÇorbası = new Nutrient() { NutrientName = "Yulaf Özü Çorbası", Quantity = 1, NutrientCategory = çorbalar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 68 }, new Scale() { ScaleType = ScaleTypes.Kase, UnitCalorie = 166 } } };
            context.Nutrients.Add(yulafÖzüÇorbası);

            Nutrient şehriyeliTavukÇorbası = new Nutrient() { NutrientName = "Şehriyeli Tavuk Çorbası", Quantity = 1, NutrientCategory = çorbalar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 84 }, new Scale() { ScaleType = ScaleTypes.Kase, UnitCalorie = 252 } } };
            context.Nutrients.Add(şehriyeliTavukÇorbası);

            Nutrient balkabağıÇorbası = new Nutrient() { NutrientName = "Balkabağı Çorbası", Quantity = 1, NutrientCategory = çorbalar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 50 }, new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 120 } } };
            context.Nutrients.Add(balkabağıÇorbası);

            Nutrient mantarÇorbası = new Nutrient() { NutrientName = "Mantar Çorbası", Quantity = 1, NutrientCategory = çorbalar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 66 }, new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 139 } } };
            context.Nutrients.Add(mantarÇorbası);

            Nutrient brokoliÇorbası = new Nutrient() { NutrientName = "Brokoli Çorbası", Quantity = 1, NutrientCategory = çorbalar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 25 }, new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 49 } } };
            context.Nutrients.Add(brokoliÇorbası);

            Nutrient unÇorbası = new Nutrient() { NutrientName = "Un Çorbası", Quantity = 1, NutrientCategory = çorbalar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 184 }, new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 92 } } };
            context.Nutrients.Add(unÇorbası);
            //TAHIL VE EKMEK GRUBU
            Nutrient buğdayEkmeği = new Nutrient() { NutrientName = "Buğday Ekmeği", Quantity = 1, NutrientCategory = tahıl, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 276 }, new Scale() { ScaleType = ScaleTypes.Dilim, UnitCalorie = 67 }, } };
            context.Nutrients.Add(buğdayEkmeği);

            Nutrient çavdarEkmeği = new Nutrient() { NutrientName = "Çavdar Ekmeği", Quantity = 1, NutrientCategory = tahıl, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 243 }, new Scale() { ScaleType = ScaleTypes.Dilim, UnitCalorie = 63 }, } };
            context.Nutrients.Add(çavdarEkmeği);

            Nutrient kepekEkmeği = new Nutrient() { NutrientName = "Kepek Ekmeği", Quantity = 1, NutrientCategory = tahıl, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 287 }, new Scale() { ScaleType = ScaleTypes.Dilim, UnitCalorie = 65 }, } };
            context.Nutrients.Add(kepekEkmeği);

            Nutrient grissini = new Nutrient() { NutrientName = "Grissini", Quantity = 1, NutrientCategory = tahıl, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 433 }, new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 98 }, } };
            context.Nutrients.Add(grissini);

            Nutrient irmik = new Nutrient() { NutrientName = "İrmik", Quantity = 1, NutrientCategory = tahıl, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 371 } } };
            context.Nutrients.Add(irmik);

            Nutrient çiğMakarna = new Nutrient() { NutrientName = "Çiğ Makarna", Quantity = 1, NutrientCategory = tahıl, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 479 }, new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 173 }, new Scale() { ScaleType = ScaleTypes.Paket, UnitCalorie = 1725 }, } };
            context.Nutrients.Add(çiğMakarna);

            Nutrient sandviçEkmeği = new Nutrient() { NutrientName = "Sandviç Ekmeği", Quantity = 1, NutrientCategory = tahıl, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 298 }, new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 178 }, } };
            context.Nutrients.Add(sandviçEkmeği);

            Nutrient böreklikYufka = new Nutrient() { NutrientName = "Böreklik Yufka", Quantity = 1, NutrientCategory = tahıl, Scales = { new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 387 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 242 } } };
            context.Nutrients.Add(böreklikYufka);

            //KURU BAKLAGİLLER
            Nutrient ayçekirdeği = new Nutrient() { NutrientName = "Ay Çekirdeği", Quantity = 1, NutrientCategory = yağlıTohumlar, Scales = { new Scale() { ScaleType = ScaleTypes.Avuç, UnitCalorie = 210 }, new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 117 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 584 } } };
            context.Nutrients.Add(ayçekirdeği);

            Nutrient badem = new Nutrient() { NutrientName = "Çiğ Badem", Quantity = 1, NutrientCategory = yağlıTohumlar, Scales = { new Scale() { ScaleType = ScaleTypes.Avuç, UnitCalorie = 149 }, new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 162 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 597 } } };
            context.Nutrients.Add(badem);

            Nutrient kuruBakla = new Nutrient() { NutrientName = "Kuru Bakla", Quantity = 1, NutrientCategory = bakliyat, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 420 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 323 } } };
            context.Nutrients.Add(kuruBakla);

            Nutrient barbunya = new Nutrient() { NutrientName = "Çiğ Barbunya", Quantity = 1, NutrientCategory = bakliyat, Scales = { new Scale() { ScaleType = ScaleTypes.Paket, UnitCalorie = 104 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 23 } } };
            context.Nutrients.Add(barbunya);

            Nutrient bezelye = new Nutrient() { NutrientName = "Çiğ Bezelye", Quantity = 1, NutrientCategory = bakliyat, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 23 }, new Scale() { ScaleType = ScaleTypes.Paket, UnitCalorie = 104 } } };
            context.Nutrients.Add(bezelye);

            Nutrient börülce = new Nutrient() { NutrientName = "Çiğ Börülce", Quantity = 1, NutrientCategory = bakliyat, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 313 }, new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 376 } } };
            context.Nutrients.Add(börülce);

            Nutrient ceviz = new Nutrient() { NutrientName = "Çiğ Ceviz", Quantity = 1, NutrientCategory = yağlıTohumlar, Scales = { new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 31 }, new Scale() { ScaleType = ScaleTypes.Avuç, UnitCalorie = 155 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 619 } } };
            context.Nutrients.Add(ceviz);

            Nutrient sarıLeblebi = new Nutrient() { NutrientName = "Sarı Leblebi", Quantity = 1, NutrientCategory = bakliyat, Scales = { new Scale() { ScaleType = ScaleTypes.ÇayBardağı, UnitCalorie = 71 }, new Scale() { ScaleType = ScaleTypes.Avuç, UnitCalorie = 47.33 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 355 } } };
            context.Nutrients.Add(sarıLeblebi);

            Nutrient beyazLeblebi = new Nutrient() { NutrientName = "Beyaz Leblebi", Quantity = 1, NutrientCategory = bakliyat, Scales = { new Scale() { ScaleType = ScaleTypes.ÇayBardağı, UnitCalorie = 72 }, new Scale() { ScaleType = ScaleTypes.Avuç, UnitCalorie = 47.5 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 357 } } };
            context.Nutrients.Add(beyazLeblebi);

            Nutrient çiğKaju = new Nutrient() { NutrientName = "Çiğ Kaju", Quantity = 1, NutrientCategory = yağlıTohumlar, Scales = { new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 111 }, new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 111 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 555 } } };
            context.Nutrients.Add(çiğKaju);

            Nutrient çamFıstığı = new Nutrient() { NutrientName = "Çam Fıstığı", Quantity = 1, NutrientCategory = yağlıTohumlar, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 115 }, new Scale() { ScaleType = ScaleTypes.Kase, UnitCalorie = 58 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 576 } } };
            context.Nutrients.Add(çamFıstığı);

            Nutrient fındık = new Nutrient() { NutrientName = "Çiğ Ceviz", Quantity = 1, NutrientCategory = yağlıTohumlar, Scales = { new Scale() { ScaleType = ScaleTypes.Avuç, UnitCalorie = 151 }, new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 13 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 628 } } };
            context.Nutrients.Add(fındık);

            Nutrient kuruFasülye = new Nutrient() { NutrientName = "Çiğ Kuru Fasülye", Quantity = 1, NutrientCategory = bakliyat, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 340 } } };
            context.Nutrients.Add(kuruFasülye);

            Nutrient kabakÇekirdeği = new Nutrient() { NutrientName = "Kabak Çekirdeği", Quantity = 1, NutrientCategory = yağlıTohumlar, Scales = { new Scale() { ScaleType = ScaleTypes.Avuç, UnitCalorie = 56 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 560 } } };
            context.Nutrients.Add(kabakÇekirdeği);

            Nutrient kestane = new Nutrient() { NutrientName = "Kestane", Quantity = 1, NutrientCategory = yağlıTohumlar, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 120 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 200 } } };
            context.Nutrients.Add(kestane);

            Nutrient mercimek = new Nutrient() { NutrientName = "Kuru Mercimek", Quantity = 1, NutrientCategory = bakliyat, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 340 } } };
            context.Nutrients.Add(mercimek);

            Nutrient nohut = new Nutrient() { NutrientName = "Nohut", Quantity = 1, NutrientCategory = bakliyat, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 360 } } };
            context.Nutrients.Add(nohut);

            Nutrient palamutÇekirdeği = new Nutrient() { NutrientName = "Palamut Çekirdeği", Quantity = 1, NutrientCategory = yağlıTohumlar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 268 } } };
            context.Nutrients.Add(palamutÇekirdeği);

            Nutrient soyaFasülyesi = new Nutrient() { NutrientName = "Soya Fasülyesi", Quantity = 1, NutrientCategory = bakliyat, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 403 } } };
            context.Nutrients.Add(soyaFasülyesi);

            Nutrient soyaUnu = new Nutrient() { NutrientName = "Soya Unu", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 356 } } };
            context.Nutrients.Add(soyaUnu);

            Nutrient susam = new Nutrient() { NutrientName = "Susam", Quantity = 1, NutrientCategory = yağlıTohumlar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 582 } } };
            context.Nutrients.Add(susam);

            Nutrient şamFıstığı = new Nutrient() { NutrientName = "Şam Fıstığı", Quantity = 1, NutrientCategory = yağlıTohumlar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 594 } } };
            context.Nutrients.Add(şamFıstığı);

            Nutrient yerFıstığı = new Nutrient() { NutrientName = "Yer Fıstığı", Quantity = 1, NutrientCategory = yağlıTohumlar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 582 } } };
            context.Nutrients.Add(yerFıstığı);

            //MEYVELER
            Nutrient ahududuKırmızı = new Nutrient() { NutrientName = "Ahududu Kırmızı", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 57 } } };
            context.Nutrients.Add(ahududuKırmızı);

            Nutrient ahududuSiyah = new Nutrient() { NutrientName = "Ahududu Siyah", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 73 } } };
            context.Nutrients.Add(ahududuSiyah);

            Nutrient ananas = new Nutrient() { NutrientName = "Ananas", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 52 } } };
            context.Nutrients.Add(ananas);

            Nutrient armut = new Nutrient() { NutrientName = "Armut", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 61 } } };
            context.Nutrients.Add(armut);

            Nutrient avokado = new Nutrient() { NutrientName = "Avokado", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 167 } } };
            context.Nutrients.Add(avokado);

            Nutrient ayva = new Nutrient() { NutrientName = "Ayva", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 57 } } };
            context.Nutrients.Add(ayva);

            Nutrient böğürtlen = new Nutrient() { NutrientName = "Böğürtlen", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 58 } } };
            context.Nutrients.Add(böğürtlen);

            Nutrient çilek = new Nutrient() { NutrientName = "Çilek", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 37 } } };
            context.Nutrients.Add(çilek);

            Nutrient dut = new Nutrient() { NutrientName = "Dut", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 93 } } };
            context.Nutrients.Add(dut);

            Nutrient elma = new Nutrient() { NutrientName = "Elma", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 58 } } };
            context.Nutrients.Add(elma);

            Nutrient erikKırmızı = new Nutrient() { NutrientName = "Kırmızı Erik", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 66 } } };
            context.Nutrients.Add(erikKırmızı);

            Nutrient erikMürdüm = new Nutrient() { NutrientName = "Mürdüm Eriği", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 79 } } };
            context.Nutrients.Add(erikMürdüm);

            Nutrient erikMürdümKuru = new Nutrient() { NutrientName = " Kuru Mürdüm Eriği", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 255 } } };
            context.Nutrients.Add(erikMürdümKuru);

            Nutrient greyfurt = new Nutrient() { NutrientName = "Greyfurt", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 41 } } };
            context.Nutrients.Add(greyfurt);

            Nutrient hurma = new Nutrient() { NutrientName = "Hurma", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 274 } } };
            context.Nutrients.Add(hurma);

            Nutrient kuruİncir = new Nutrient() { NutrientName = "Kuru İncir", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 274 } } };
            context.Nutrients.Add(kuruİncir);

            Nutrient tazeİncir = new Nutrient() { NutrientName = "Taze İncir", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 80 } } };
            context.Nutrients.Add(tazeİncir);

            Nutrient kuruKayısı = new Nutrient() { NutrientName = "Kuru Kayısı", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 260 } } };
            context.Nutrients.Add(kuruKayısı);

            Nutrient tazeKayısı = new Nutrient() { NutrientName = "Taze Kayısı", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 17 } } };
            context.Nutrients.Add(tazeKayısı);

            Nutrient karpuz = new Nutrient() { NutrientName = "Karpuz", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 26 } } };
            context.Nutrients.Add(karpuz);

            Nutrient kavun = new Nutrient() { NutrientName = "Kavun", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 33 } } };
            context.Nutrients.Add(kavun);

            Nutrient kiraz = new Nutrient() { NutrientName = "Kiraz", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 5 } } };
            context.Nutrients.Add(kiraz);

            Nutrient kivi = new Nutrient() { NutrientName = "Kivi", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 30 } } };
            context.Nutrients.Add(kivi);

            Nutrient limon = new Nutrient() { NutrientName = "Limon", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 27 } } };
            context.Nutrients.Add(limon);

            Nutrient mandalina = new Nutrient() { NutrientName = "Mandalina", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 46 } } };
            context.Nutrients.Add(mandalina);

            Nutrient muz = new Nutrient() { NutrientName = "Muz", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 105 } } };
            context.Nutrients.Add(muz);

            Nutrient nar = new Nutrient() { NutrientName = "Nar", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 63 } } };
            context.Nutrients.Add(nar);

            Nutrient portakal = new Nutrient() { NutrientName = "Portakal", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 49 } } };
            context.Nutrients.Add(portakal);

            Nutrient şeftali = new Nutrient() { NutrientName = "Şeftali", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 38 } } };
            context.Nutrients.Add(şeftali);

            Nutrient kuruÜzüm = new Nutrient() { NutrientName = "Kuru Üzüm", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 289 } } };
            context.Nutrients.Add(kuruÜzüm);

            Nutrient tazeÜzüm = new Nutrient() { NutrientName = "Taze Üzüm", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 67 } } };
            context.Nutrients.Add(tazeÜzüm);

            Nutrient vişne = new Nutrient() { NutrientName = "Vişne", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 58 } } };
            context.Nutrients.Add(vişne);

            //SAĞLIKSIZ ATIŞTIRMALIKLAR

            Nutrient cipsi = new Nutrient() { NutrientName = "Cipsi", Quantity = 1, NutrientCategory = sağlıksızAtıştırmalıklar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 540 }, new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 135 } } };
            context.Nutrients.Add(cipsi);

            Nutrient çikolata = new Nutrient() { NutrientName = "Çikolata", Quantity = 1, NutrientCategory = sağlıksızAtıştırmalıklar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 540 }, new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 135 } } };
            context.Nutrients.Add(çikolata);

            Nutrient patlamışMısır = new Nutrient() { NutrientName = "Patlamış Mısır", Quantity = 1, NutrientCategory = sağlıksızAtıştırmalıklar, Scales = { new Scale() { ScaleType = ScaleTypes.Avuç, UnitCalorie = 52 }, new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 140 } } };
            context.Nutrients.Add(patlamışMısır);

            Nutrient fındıkKremalıGofret = new Nutrient() { NutrientName = "Fındık Kremali Gofret", Quantity = 1, NutrientCategory = sağlıksızAtıştırmalıklar, Scales = { new Scale() { ScaleType = ScaleTypes.Paket, UnitCalorie = 247 }, new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 25 } } };
            context.Nutrients.Add(fındıkKremalıGofret);

            Nutrient rulokat = new Nutrient() { NutrientName = "Rulokat", Quantity = 1, NutrientCategory = sağlıksızAtıştırmalıklar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 516 } } };
            context.Nutrients.Add(rulokat);

            Nutrient metroÇikolata = new Nutrient() { NutrientName = "Metro Çikolata", Quantity = 1, NutrientCategory = sağlıksızAtıştırmalıklar, Scales = { new Scale() { ScaleType = ScaleTypes.Paket, UnitCalorie = 184 } } };
            context.Nutrients.Add(metroÇikolata);

            Nutrient pringlesOriginal = new Nutrient() { NutrientName = "Pringles-Original", Quantity = 1, NutrientCategory = sağlıksızAtıştırmalıklar, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 157 } } };
            context.Nutrients.Add(pringlesOriginal);

            Nutrient browniIntense = new Nutrient() { NutrientName = "Browni Intense", Quantity = 1, NutrientCategory = sağlıksızAtıştırmalıklar, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 232 }, new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 74 } } };
            context.Nutrients.Add(browniIntense);

            Nutrient popKek = new Nutrient() { NutrientName = "Eti Popkek Limonlu", Quantity = 1, NutrientCategory = sağlıksızAtıştırmalıklar, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 264 } } };
            context.Nutrients.Add(popKek);

            Nutrient cocoStar = new Nutrient() { NutrientName = "CocoStar", Quantity = 1, NutrientCategory = sağlıksızAtıştırmalıklar, Scales = { new Scale() { ScaleType = ScaleTypes.Paket, UnitCalorie = 148 } } };
            context.Nutrients.Add(cocoStar);

            Nutrient kremalıBisküvi = new Nutrient() { NutrientName = "Kremalı Bisküvi", Quantity = 1, NutrientCategory = sağlıksızAtıştırmalıklar, Scales = { new Scale() { ScaleType = ScaleTypes.Paket, UnitCalorie = 328 }, new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 100 }, new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 143 } } };
            context.Nutrients.Add(kremalıBisküvi);

            Nutrient kakaoluBisküvi = new Nutrient() { NutrientName = "Kakaolu Bisküvi", Quantity = 1, NutrientCategory = sağlıksızAtıştırmalıklar, Scales = { new Scale() { ScaleType = ScaleTypes.Paket, UnitCalorie = 533 } } };
            context.Nutrients.Add(kakaoluBisküvi);

            Nutrient kakaoluPuding = new Nutrient() { NutrientName = "Kakaolu Puding", Quantity = 1, NutrientCategory = sağlıksızAtıştırmalıklar, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 132 } } };
            context.Nutrients.Add(kakaoluPuding);


            //SAĞLIKLI ATIŞTIRMALIKLAR
            Nutrient peynirliDiyetKraker = new Nutrient() { NutrientName = "Peynirli Diyet Kraker", Quantity = 1, NutrientCategory = sağlıklıAtıştırmalıklar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 479 }, new Scale() { ScaleType = ScaleTypes.Paket, UnitCalorie = 146 } } };
            context.Nutrients.Add(peynirliDiyetKraker);

            Nutrient etiFormÇörekotlu = new Nutrient() { NutrientName = "EtiForm Çörekotlu Kepekli Tuzlu Bisküvi", Quantity = 1, NutrientCategory = sağlıklıAtıştırmalıklar, Scales = { new Scale() { ScaleType = ScaleTypes.Paket, UnitCalorie = 116 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 362.5 } } };
            context.Nutrients.Add(etiFormÇörekotlu);

            Nutrient etiFormKepekli = new Nutrient() { NutrientName = "EtiForm Kepekli Light Bisküvi", Quantity = 1, NutrientCategory = sağlıklıAtıştırmalıklar, Scales = { new Scale() { ScaleType = ScaleTypes.Paket, UnitCalorie = 184 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 408.9 } } };
            context.Nutrients.Add(etiFormKepekli);

            Nutrient etiFormBuğdayPatlağı = new Nutrient() { NutrientName = "EtiForm Çok Tahıllı Buğday Patlağı", Quantity = 1, NutrientCategory = sağlıklıAtıştırmalıklar, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 365 } } };
            context.Nutrients.Add(etiFormBuğdayPatlağı);

            Nutrient etiFormLimonlu = new Nutrient() { NutrientName = "EtiForm Limon Lifli Kepekli Bisküvi", Quantity = 1, NutrientCategory = sağlıklıAtıştırmalıklar, Scales = { new Scale() { ScaleType = ScaleTypes.Paket, UnitCalorie = 162.45 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 391 } } };
            context.Nutrients.Add(etiFormLimonlu);

            Nutrient etiFormÇikolataKaplı = new Nutrient() { NutrientName = "EtiForm Çikolata Kaplı Lifli Bisküvi", Quantity = 1, NutrientCategory = sağlıklıAtıştırmalıklar, Scales = { new Scale() { ScaleType = ScaleTypes.Paket, UnitCalorie = 202 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 360.72 } } };
            context.Nutrients.Add(etiFormÇikolataKaplı);

            Nutrient etiFormKarabuğdaylıÇıtırÇubuk = new Nutrient() { NutrientName = "EtiForm Karabuğdaylı Çıtır Çubuk", Quantity = 1, NutrientCategory = sağlıklıAtıştırmalıklar, Scales = { new Scale() { ScaleType = ScaleTypes.Paket, UnitCalorie = 199 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 398 } } };
            context.Nutrients.Add(etiFormKarabuğdaylıÇıtırÇubuk);

            Nutrient etiFormEkşiMaya = new Nutrient() { NutrientName = "EtiForm Ekşi Mayalı Bisküvi", Quantity = 1, NutrientCategory = sağlıklıAtıştırmalıklar, Scales = { new Scale() { ScaleType = ScaleTypes.Paket, UnitCalorie = 180 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 400 } } };
            context.Nutrients.Add(etiFormEkşiMaya);

            Nutrient etiFormZeytinli = new Nutrient() { NutrientName = "EtiForm Zeytinli Kinoalı Bisküvi", Quantity = 1, NutrientCategory = sağlıklıAtıştırmalıklar, Scales = { new Scale() { ScaleType = ScaleTypes.Paket, UnitCalorie = 173.7 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 386 } } };
            context.Nutrients.Add(etiFormZeytinli);

            Nutrient çokTahıllıÇıtırÇubuk = new Nutrient() { NutrientName = "EtiForm Çok Tahıllı Çıtır Çubuk", Quantity = 1, NutrientCategory = sağlıklıAtıştırmalıklar, Scales = { new Scale() { ScaleType = ScaleTypes.Paket, UnitCalorie = 180 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 400 } } };
            context.Nutrients.Add(çokTahıllıÇıtırÇubuk);
            //TATLILAR

            Nutrient sütlaç = new Nutrient() { NutrientName = "Sütlaç", Quantity = 1, NutrientCategory = tatlılar, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 268 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 32 }, new Scale() { ScaleType = ScaleTypes.TatlıKaşığı, UnitCalorie = 21 } } };
            context.Nutrients.Add(sütlaç);

            Nutrient fırınSütlaç = new Nutrient() { NutrientName = "Fırın Sütlaç", Quantity = 1, NutrientCategory = tatlılar, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 286 } } };
            context.Nutrients.Add(fırınSütlaç);

            Nutrient hintSütlacı = new Nutrient() { NutrientName = "Hint Sütlacı", Quantity = 1, NutrientCategory = tatlılar, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 327 } } };
            context.Nutrients.Add(hintSütlacı);

            Nutrient halkaTatlısı = new Nutrient() { NutrientName = "Halka Tatlısı", Quantity = 1, NutrientCategory = tatlılar, Scales = { new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 329 }, new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 673 } } };
            context.Nutrients.Add(halkaTatlısı);

            Nutrient tavukGöğüsü = new Nutrient() { NutrientName = "Tavuk Göğüsü Tatlısı", Quantity = 1, NutrientCategory = tatlılar, Scales = { new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 24 }, new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 165 }, new Scale() { ScaleType = ScaleTypes.TatlıKaşığı, UnitCalorie = 12 } } };
            context.Nutrients.Add(tavukGöğüsü);

            Nutrient profiterol = new Nutrient() { NutrientName = "Profiterol", Quantity = 1, NutrientCategory = tatlılar, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 429 } } };
            context.Nutrients.Add(profiterol);

            Nutrient kadayıflıMuhallebi = new Nutrient() { NutrientName = "Kadayıflı Muhallebi", Quantity = 1, NutrientCategory = tatlılar, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 199 } } };
            context.Nutrients.Add(kadayıflıMuhallebi);

            Nutrient fıstıklıTelKadayıf = new Nutrient() { NutrientName = "Fıstıklı Tel Kadayıf", Quantity = 1, NutrientCategory = tatlılar, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 382 } } };
            context.Nutrients.Add(fıstıklıTelKadayıf);

            Nutrient baklava = new Nutrient() { NutrientName = "Baklava", Quantity = 1, NutrientCategory = tatlılar, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 659 }, new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 165 } } };
            context.Nutrients.Add(baklava);

            Nutrient Muhallebi = new Nutrient() { NutrientName = "Muhallebi", Quantity = 1, NutrientCategory = tatlılar, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 233 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 23 }, new Scale() { ScaleType = ScaleTypes.TatlıKaşığı, UnitCalorie = 11 } } };
            context.Nutrients.Add(Muhallebi);

            Nutrient Helva = new Nutrient() { NutrientName = "Helva", Quantity = 1, NutrientCategory = tatlılar, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 190 } } };
            context.Nutrients.Add(Helva);

            Nutrient Şekerpare = new Nutrient() { NutrientName = "Şekerpare", Quantity = 1, NutrientCategory = tatlılar, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 544 }, new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 136 } } };
            context.Nutrients.Add(Şekerpare);

            Nutrient kazandibi = new Nutrient() { NutrientName = "Kazandibi", Quantity = 1, NutrientCategory = tatlılar, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 201 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 32 }, new Scale() { ScaleType = ScaleTypes.TatlıKaşığı, UnitCalorie = 26 } } };
            context.Nutrients.Add(kazandibi);

            Nutrient aşure = new Nutrient() { NutrientName = "Aşure", Quantity = 1, NutrientCategory = tatlılar, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 344 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 63 } } };
            context.Nutrients.Add(aşure);

            Nutrient çikolatalıPasta = new Nutrient() { NutrientName = "Çikolatalı Pasta", Quantity = 1, NutrientCategory = tatlılar, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 577 }, new Scale() { ScaleType = ScaleTypes.Kase, UnitCalorie = 385 } } };
            context.Nutrients.Add(çikolatalıPasta);

            Nutrient muzluRuloPasta = new Nutrient() { NutrientName = "Muzlu Rulo Pasta", Quantity = 1, NutrientCategory = tatlılar, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 250 } } };
            context.Nutrients.Add(muzluRuloPasta);

            Nutrient bisküviliPasta = new Nutrient() { NutrientName = "Bisküvili Pasta", Quantity = 1, NutrientCategory = tatlılar, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 427 }, new Scale() { ScaleType = ScaleTypes.Kase, UnitCalorie = 361 } } };
            context.Nutrients.Add(bisküviliPasta);


            //İÇECEKLER 

            Nutrient bira = new Nutrient() { NutrientName = "Bira", Quantity = 1, NutrientCategory = içecekler, Scales = { new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 84 } } };
            context.Nutrients.Add(bira);

            Nutrient şarap = new Nutrient() { NutrientName = "Şarap", Quantity = 1, NutrientCategory = içecekler, Scales = { new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 74 } } };
            context.Nutrients.Add(şarap);

            Nutrient kola = new Nutrient() { NutrientName = "Kola", Quantity = 1, NutrientCategory = içecekler, Scales = { new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 122 } } };
            context.Nutrients.Add(kola);

            Nutrient fanta = new Nutrient() { NutrientName = "Fanta", Quantity = 1, NutrientCategory = içecekler, Scales = { new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 95 } } };
            context.Nutrients.Add(fanta);

            Nutrient birKüpŞekerliÇay = new Nutrient() { NutrientName = "1 Küp Şekerli Çay", Quantity = 1, NutrientCategory = içecekler, Scales = { new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 21 } } };
            context.Nutrients.Add(birKüpŞekerliÇay); // Fincan normal alınmıştır su bardağı gibi.

            Nutrient ayran = new Nutrient() { NutrientName = "Ayran", Quantity = 1, NutrientCategory = içecekler, Scales = { new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 75 }, new Scale() { ScaleType = ScaleTypes.MLitre, UnitCalorie = 55 } } };
            context.Nutrients.Add(ayran);

            Nutrient adaÇayı = new Nutrient() { NutrientName = "Ada Çayı", Quantity = 1, NutrientCategory = içecekler, Scales = { new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 2 } } };
            context.Nutrients.Add(adaÇayı);

            Nutrient tamekMeyveSuyu = new Nutrient() { NutrientName = "Tamek Meyve Suyu", Quantity = 1, NutrientCategory = içecekler, Scales = { new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 100 } } };
            context.Nutrients.Add(tamekMeyveSuyu);

            Nutrient şalgamSuyu = new Nutrient() { NutrientName = "Şalgam Suyu", Quantity = 1, NutrientCategory = içecekler, Scales = { new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 10 } } };
            context.Nutrients.Add(şalgamSuyu);

            Nutrient votka = new Nutrient() { NutrientName = "Votka", Quantity = 1, NutrientCategory = içecekler, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 232 } } };
            context.Nutrients.Add(votka);

            Nutrient liptonIceTea = new Nutrient() { NutrientName = "Lipton İce Tea", Quantity = 1, NutrientCategory = içecekler, Scales = { new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 60 } } };
            context.Nutrients.Add(liptonIceTea);

            Nutrient rakı = new Nutrient() { NutrientName = "Rakı", Quantity = 1, NutrientCategory = içecekler, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 200 } } };
            context.Nutrients.Add(rakı);

            Nutrient gazoz = new Nutrient() { NutrientName = "Gazoz", Quantity = 1, NutrientCategory = içecekler, Scales = { new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 190 } } };
            context.Nutrients.Add(gazoz);

            Nutrient sütlüKahve = new Nutrient() { NutrientName = "Sütlü Kahve", Quantity = 1, NutrientCategory = içecekler, Scales = { new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 71 } } };
            context.Nutrients.Add(sütlüKahve);

            Nutrient süt = new Nutrient() { NutrientName = "Süt", Quantity = 1, NutrientCategory = sütÜrünleri, Scales = { new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 122 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 61 }, new Scale() { ScaleType = ScaleTypes.MLitre, UnitCalorie = 45 } } };
            context.Nutrients.Add(süt);

            //SEBZE GRUBU 
            Nutrient patates = new Nutrient() { NutrientName = "Patates", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 77 } } };
            context.Nutrients.Add(patates);

            Nutrient marul = new Nutrient() { NutrientName = "Marul", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 16 } } };
            context.Nutrients.Add(marul);

            Nutrient roka = new Nutrient() { NutrientName = "Roka", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 25 } } };
            context.Nutrients.Add(roka);

            Nutrient ıspanak = new Nutrient() { NutrientName = "Ispanak", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 19 } } };
            context.Nutrients.Add(ıspanak);

            Nutrient patlıcan = new Nutrient() { NutrientName = "Patlıcan", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 17 } } };
            context.Nutrients.Add(patlıcan);

            Nutrient salatalık = new Nutrient() { NutrientName = "Salatalık", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 18 } } };
            context.Nutrients.Add(salatalık);

            Nutrient morLahana = new Nutrient() { NutrientName = "Mor Lahana", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 54 }, new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 115 } } };
            context.Nutrients.Add(morLahana);

            Nutrient kereviz = new Nutrient() { NutrientName = "Kereviz", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 42 }, new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 126 } } };
            context.Nutrients.Add(kereviz);

            Nutrient brokoli = new Nutrient() { NutrientName = "Brokoli", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 39 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 26 } } };
            context.Nutrients.Add(brokoli);

            Nutrient yeşilSoğan = new Nutrient() { NutrientName = "Yeşil Soğan", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 15 } } };
            context.Nutrients.Add(yeşilSoğan);

            Nutrient tazeFasulye = new Nutrient() { NutrientName = "Taze Fasulye", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 47 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 31 } } };
            context.Nutrients.Add(tazeFasulye);

            Nutrient pırsa = new Nutrient() { NutrientName = "Pırasa", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 92 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 100 } } };
            context.Nutrients.Add(pırsa);

            Nutrient bezelyeYemeği = new Nutrient() { NutrientName = "Bezelye Yemeği", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 235 } } };
            context.Nutrients.Add(bezelyeYemeği);

            Nutrient dereOtu = new Nutrient() { NutrientName = "Dere Otu", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 7 } } };
            context.Nutrients.Add(dereOtu);

            Nutrient kırmızıTurp = new Nutrient() { NutrientName = "Kırmızı Turp", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 16 } } };
            context.Nutrients.Add(kırmızıTurp);

            Nutrient beyazTurp = new Nutrient() { NutrientName = "Beyaz Turp", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 21 } } };
            context.Nutrients.Add(beyazTurp);

            Nutrient karnabahar = new Nutrient() { NutrientName = "Karnabahar", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 38 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 25 } } };
            context.Nutrients.Add(karnabahar);

            Nutrient kuşkonmaz = new Nutrient() { NutrientName = "Kuşkonmaz", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 33 } } };
            context.Nutrients.Add(kuşkonmaz);

            Nutrient enginar = new Nutrient() { NutrientName = "Enginar", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 71 }, new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 47 } } };
            context.Nutrients.Add(enginar);

            Nutrient semizOtu = new Nutrient() { NutrientName = "Semizotu", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 27 }, new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 2 } } };
            context.Nutrients.Add(semizOtu);

            Nutrient kabak = new Nutrient() { NutrientName = "Kabak", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 29 } } };
            context.Nutrients.Add(kabak);

            Nutrient yerElması = new Nutrient() { NutrientName = "Yer Elması", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 88 }, new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 44 } } };
            context.Nutrients.Add(yerElması);

            Nutrient buhardaPazı = new Nutrient() { NutrientName = "BuhardaPazı", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 29 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 3 } } };
            context.Nutrients.Add(buhardaPazı);

            Nutrient havuç = new Nutrient() { NutrientName = "Havuç", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 55 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 35.25 } } };
            context.Nutrients.Add(havuç);

            //SEBZE YEMEKLERİ
            Nutrient ıspanakYemeğiPirinç = new Nutrient() { NutrientName = "Pirinçli veya Bulgurlu Ispanak Yemeği", Quantity = 1, NutrientCategory = tahılveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 115 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 115 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 23 } } };
            context.Nutrients.Add(ıspanakYemeğiPirinç);

            Nutrient ıspanakYemeğiEtli = new Nutrient() { NutrientName = "Etli veya Kıymalı Ispanak Yemeği", Quantity = 1, NutrientCategory = etveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 144.5 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 111.2 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 24.1 } } };
            context.Nutrients.Add(ıspanakYemeğiEtli);

            Nutrient zeytinyağlıSemizOtu = new Nutrient() { NutrientName = "Pirinçli veya Bulgurlu Semizotu Yemeği", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 112 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 112 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 22.4 } } };
            context.Nutrients.Add(zeytinyağlıSemizOtu);
            Nutrient etliSemizOtuYemeği = new Nutrient() { NutrientName = "Etli Semizotu Yemeği", Quantity = 1, NutrientCategory = etveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 141.5 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 109 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 23.59 } } };
            context.Nutrients.Add(etliSemizOtuYemeği);

            Nutrient pazıYemeğiPirinç = new Nutrient() { NutrientName = "Pirinçli veya Bulgurlu Pazı Yemeği", Quantity = 1, NutrientCategory = tahılveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 131 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 131 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 26.2 } } };
            context.Nutrients.Add(pazıYemeğiPirinç);

            Nutrient pazıYemeğiEt = new Nutrient() { NutrientName = "Etli veya Kıymalı Pazı Yemeği", Quantity = 1, NutrientCategory = etveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 160 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 123 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 26.67 } } };
            context.Nutrients.Add(pazıYemeğiEt);

            Nutrient zyağlıTazeFasülye = new Nutrient() { NutrientName = "Zeytinyağlı Taze Fasülye", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 151 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 151 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 30.2 } } };
            context.Nutrients.Add(zyağlıTazeFasülye);

            Nutrient etliTazeFasülye = new Nutrient() { NutrientName = "Etli Taze Fasülye", Quantity = 1, NutrientCategory = etveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 180.5 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 138.85 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 23.15 } } };
            context.Nutrients.Add(etliTazeFasülye);

            Nutrient zyağlıPırasa = new Nutrient() { NutrientName = "Zeytinyağlı Pırasa (Pirinçli veya Nohutlu)", Quantity = 1, NutrientCategory = tahılveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 120 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 120 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 24 } } };
            context.Nutrients.Add(zyağlıPırasa);

            Nutrient zyağlıbezelyeYemeği = new Nutrient() { NutrientName = "Zeytinyağlı Bezelye Yemeği", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 147 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 147 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 29.4 } } };
            context.Nutrients.Add(zyağlıbezelyeYemeği);

            Nutrient etlibezelyeYemeği = new Nutrient() { NutrientName = "Etli Bezelye Yemeği", Quantity = 1, NutrientCategory = etveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 176.5 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 136 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 29.42 } } };
            context.Nutrients.Add(etlibezelyeYemeği);

            Nutrient zyağlıBrokoliYemeği = new Nutrient() { NutrientName = "Zeytinyağlı Brokoli Yemeği", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 80 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 80 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 16 } } };
            context.Nutrients.Add(zyağlıBrokoliYemeği);

            Nutrient etliBrokoliYemeği = new Nutrient() { NutrientName = "Etli Brokoli Yemeği", Quantity = 1, NutrientCategory = etveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 110 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 84.62 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 18.34 } } };
            context.Nutrients.Add(etliBrokoliYemeği);

            Nutrient zyağlıkarnabaharYemeği = new Nutrient() { NutrientName = "Zeytinyağlı Karnabahar Yemeği", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 115 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 115 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 23 } } };
            context.Nutrients.Add(zyağlıkarnabaharYemeği);

            Nutrient etlikarnabaharYemeği = new Nutrient() { NutrientName = "Etli Karnabahar Yemeği", Quantity = 1, NutrientCategory = etveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 144.5 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 111.16 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 24.08 } } };
            context.Nutrients.Add(etlikarnabaharYemeği);

            Nutrient zyağlıBamyaYemeği = new Nutrient() { NutrientName = "Zeytinyağlı Bamya Yemeği", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 113 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 113 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 22.6 } } };
            context.Nutrients.Add(zyağlıBamyaYemeği);

            Nutrient etliBamyaYemeği = new Nutrient() { NutrientName = "Etli Bamya Yemeği", Quantity = 1, NutrientCategory = etveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 142.5 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 109.62 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 23.75 } } };
            context.Nutrients.Add(etliBamyaYemeği);

            Nutrient zyağlıTürlüYemeği = new Nutrient() { NutrientName = "Zeytinyağlı Türlü Yemeği", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 112 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 112 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 22.4 } } };
            context.Nutrients.Add(zyağlıTürlüYemeği);

            Nutrient etliTürlüYemeği = new Nutrient() { NutrientName = "Etli Türlü Yemeği", Quantity = 1, NutrientCategory = etveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 141.5 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 109 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 23.59 } } };
            context.Nutrients.Add(etliTürlüYemeği);

            Nutrient zyağlıBakla = new Nutrient() { NutrientName = "Zeytinyağlı Bakla Yemeği", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 145 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 145 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 29 } } };
            context.Nutrients.Add(zyağlıBakla);

            Nutrient zyağlıKereviz = new Nutrient() { NutrientName = "Zeytinyağlı Kereviz Yemeği", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 90 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 90 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 18 } } };
            context.Nutrients.Add(zyağlıKereviz);

            Nutrient zyağlıEnginar = new Nutrient() { NutrientName = "Zeytinyağlı Enginar Yemeği", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 146 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 146 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 29.2 } } };
            context.Nutrients.Add(zyağlıEnginar);

            Nutrient etliMantarSote = new Nutrient() { NutrientName = "Etli veya Tavuklu Mantar Sote Yemeği", Quantity = 1, NutrientCategory = etveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 118 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 90.8 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 23.6 } } };
            context.Nutrients.Add(etliMantarSote);

            Nutrient sebzeSote = new Nutrient() { NutrientName = "Sebze Sote Yemeği", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 90 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 45 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 20 } } };
            context.Nutrients.Add(sebzeSote);

            Nutrient zyağlıSebzeDolması = new Nutrient() { NutrientName = "Zeytinyağlı Sebze Dolması", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 258 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 129 }, new Scale() { ScaleType = ScaleTypes.Kase, UnitCalorie = 258 } } };
            context.Nutrients.Add(zyağlıSebzeDolması);

            Nutrient zyağlıYaprakSarma = new Nutrient() { NutrientName = "Zeytinyağlı Yaprak Sarma", Quantity = 1, NutrientCategory = tahıl, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 108 }, new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 36 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 180 } } };
            context.Nutrients.Add(zyağlıYaprakSarma);

            Nutrient etliSebzeDolması = new Nutrient() { NutrientName = "Etli Sebze Dolması", Quantity = 1, NutrientCategory = etveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 358 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 179 }, new Scale() { ScaleType = ScaleTypes.Kase, UnitCalorie = 358 } } };
            context.Nutrients.Add(etliSebzeDolması);

            Nutrient etliYaprakSarma = new Nutrient() { NutrientName = "Etli Yaprak Sarma", Quantity = 1, NutrientCategory = etveTahılGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 176 }, new Scale() { ScaleType = ScaleTypes.Adet, UnitCalorie = 35.2 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 176 } } };
            context.Nutrients.Add(etliYaprakSarma);

            Nutrient zyağlıKabakYemeği = new Nutrient() { NutrientName = "Zeytinyağlı Kabak Yemeği", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 111 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 111 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 22.2 } } };
            context.Nutrients.Add(zyağlıKabakYemeği);

            Nutrient etliKabakYemeği = new Nutrient() { NutrientName = "Etli Kabak Yemeği", Quantity = 1, NutrientCategory = etveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 140.5 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 109 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 23.41 } } };
            context.Nutrients.Add(etliKabakYemeği);

            Nutrient mercimekYemeği = new Nutrient() { NutrientName = "Zeytinyağlı Mercimek Yemeği", Quantity = 1, NutrientCategory = bakliyat, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 100.2 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 167 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 33.4 } } };
            context.Nutrients.Add(mercimekYemeği);

            Nutrient etlimercimekYemeği = new Nutrient() { NutrientName = "Etli Mercimek Yemeği", Quantity = 1, NutrientCategory = etveBakliyatGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 160 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 178 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 40 } } };
            context.Nutrients.Add(etlimercimekYemeği);

            Nutrient nohutYemeği = new Nutrient() { NutrientName = "Zeytinyağlı Nohut Yemeği", Quantity = 1, NutrientCategory = bakliyat, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 101.4 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 169 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 33.8 } } };
            context.Nutrients.Add(nohutYemeği);

            Nutrient etlinohutYemeği = new Nutrient() { NutrientName = "Etli Nohut Yemeği", Quantity = 1, NutrientCategory = etveBakliyatGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 160.4 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 178.22 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 40.1 } } };
            context.Nutrients.Add(etlinohutYemeği);

            Nutrient zyağlıKuruFasülyeYemeği = new Nutrient() { NutrientName = "Zeytinyağlı Kuru Fasülye Yemeği", Quantity = 1, NutrientCategory = bakliyat, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 101.4 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 169 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 33.8 } } };
            context.Nutrients.Add(zyağlıKuruFasülyeYemeği);

            Nutrient etliKuruFasülyeYemeği = new Nutrient() { NutrientName = "Etli Kuru Fasülye Yemeği", Quantity = 1, NutrientCategory = etveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 178.22 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 169 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 40.1 } } };
            context.Nutrients.Add(etliKuruFasülyeYemeği);

            Nutrient zyağlıBarbunya = new Nutrient() { NutrientName = "Zeytinyağlı Barbunya Yemeği", Quantity = 1, NutrientCategory = bakliyat, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 101.4 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 169 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 33.8 } } };
            context.Nutrients.Add(zyağlıBarbunya);

            Nutrient bulgurPilavı = new Nutrient() { NutrientName = "Bulgur Pilavı", Quantity = 1, NutrientCategory = tahıl, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 80 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 133.34 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 26.67 } } };
            context.Nutrients.Add(bulgurPilavı);

            Nutrient sebzeliBulgurPilavı = new Nutrient() { NutrientName = "Sebzeli Bulgur Pilavı", Quantity = 1, NutrientCategory = tahılveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 108 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 120 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 27 } } };
            context.Nutrients.Add(sebzeliBulgurPilavı);

            Nutrient pirinçPilavı = new Nutrient() { NutrientName = "Pirinç Pilavı", Quantity = 1, NutrientCategory = tahıl, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 75 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 125 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 25 } } };
            context.Nutrients.Add(pirinçPilavı);

            Nutrient sebzeliPirinçPilavı = new Nutrient() { NutrientName = "Sebzeli Pirinç Pilavı", Quantity = 1, NutrientCategory = tahılveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 103 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 114.45 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 25.75 } } };
            context.Nutrients.Add(sebzeliPirinçPilavı);

            Nutrient şehriyePilavı = new Nutrient() { NutrientName = "Şehriye Pilavı", Quantity = 1, NutrientCategory = tahıl, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 77.4 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 129 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 25.8 } } };
            context.Nutrients.Add(şehriyePilavı);

            Nutrient haşlamaMakarna = new Nutrient() { NutrientName = "Haşlama Makarna (Sade)", Quantity = 1, NutrientCategory = tahıl, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 74.4 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 124 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 24.8 } } };
            context.Nutrients.Add(haşlamaMakarna);

            Nutrient kıymalıMakarna = new Nutrient() { NutrientName = "Kıymalı Makarna", Quantity = 1, NutrientCategory = etveTahılGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 133.4 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 148.22 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 33.35 } } };
            context.Nutrients.Add(kıymalıMakarna);

            Nutrient peynirliMakarna = new Nutrient() { NutrientName = "Peynirli Makarna", Quantity = 1, NutrientCategory = tahıl, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 133.4 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 130.44 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 29.35 } } };
            context.Nutrients.Add(peynirliMakarna);

            //SALATALAR
            Nutrient sadeSalata = new Nutrient() { NutrientName = "Sade Salata (Karışık Yaşillik)", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 9 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 17 } } };
            context.Nutrients.Add(sadeSalata);

            Nutrient mercimekliLorPeynirliSalata = new Nutrient() { NutrientName = "Mercimekli Lor Peynirli Salata", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 180 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 71 } } };
            context.Nutrients.Add(mercimekliLorPeynirliSalata);

            Nutrient tavukluSalata = new Nutrient() { NutrientName = "Tavuklu Salata", Quantity = 1, NutrientCategory = etveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 225 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 89 } } };
            context.Nutrients.Add(tavukluSalata);

            Nutrient etliSalata = new Nutrient() { NutrientName = "Etli Salata", Quantity = 1, NutrientCategory = etveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 267 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 103 } } };
            context.Nutrients.Add(etliSalata);

            Nutrient tonBalıklıSalata = new Nutrient() { NutrientName = "Ton Balıklı Salata", Quantity = 1, NutrientCategory = etveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 215 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 80 } } };
            context.Nutrients.Add(tonBalıklıSalata);

            Nutrient tabuleSalatası = new Nutrient() { NutrientName = "Tabule Salatası", Quantity = 1, NutrientCategory = tahılveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 588 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 159 } } };
            context.Nutrients.Add(tabuleSalatası);

            Nutrient lorpeynirliYumurtalıSalata = new Nutrient() { NutrientName = "Lor Peynirli Yumurtalı Salata", Quantity = 1, NutrientCategory = etveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 225 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 87 } } };
            context.Nutrients.Add(lorpeynirliYumurtalıSalata);

            Nutrient kısır = new Nutrient() { NutrientName = "Kısır", Quantity = 1, NutrientCategory = tahıl, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 108 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 180 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 27 } } };
            context.Nutrients.Add(kısır);

            Nutrient mercimekKöftesi = new Nutrient() { NutrientName = "Mercimek Köftesi", Quantity = 1, NutrientCategory = bakliyat, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 70 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 233 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 35 } } };
            context.Nutrients.Add(mercimekKöftesi);

            //OMLETLER
            Nutrient peynirliOmlet = new Nutrient() { NutrientName = "Peynirli Omlet", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 254 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 195.39 } } };
            context.Nutrients.Add(peynirliOmlet);

            Nutrient mantarlıOmlet = new Nutrient() { NutrientName = "Mantarlı Omlet", Quantity = 1, NutrientCategory = etveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 205 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 136.67 } } };
            context.Nutrients.Add(mantarlıOmlet);

            Nutrient menemen = new Nutrient() { NutrientName = "Menemen", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 205 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 136.67 } } };
            context.Nutrients.Add(menemen);

            Nutrient kaşarlıOmlet = new Nutrient() { NutrientName = "Kaşarlı Omlet", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 260.3 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 200.23 } } };
            context.Nutrients.Add(kaşarlıOmlet);

            Nutrient sebzeliOmlet = new Nutrient() { NutrientName = "Sebzeli Omlet", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 205 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 136.67 } } };
            context.Nutrients.Add(sebzeliOmlet);

            Nutrient yulaflıOmlet = new Nutrient() { NutrientName = "Yulaflı Omlet", Quantity = 1, NutrientCategory = etveTahılGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 258 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 215 } } };
            context.Nutrients.Add(yulaflıOmlet);

            Nutrient sadeOmlet = new Nutrient() { NutrientName = "Sade Omlet", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 185 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 195 } } };
            context.Nutrients.Add(sadeOmlet);

            //SÜT ÜRÜNLERİ
            //SÜTLER
            Nutrient inekSütü = new Nutrient() { NutrientName = " Tam Yağlı İnek Sütü", Quantity = 1, NutrientCategory = sütÜrünleri, Scales = { new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 110 }, new Scale() { ScaleType = ScaleTypes.MLitre, UnitCalorie = 55 } } };
            context.Nutrients.Add(inekSütü);

            Nutrient yarımYağlıİnekSütü = new Nutrient() { NutrientName = " Yarım Yağlı İnek Sütü", Quantity = 1, NutrientCategory = sütÜrünleri, Scales = { new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 92 }, new Scale() { ScaleType = ScaleTypes.MLitre, UnitCalorie = 46 } } };
            context.Nutrients.Add(yarımYağlıİnekSütü);

            Nutrient yağsızİnekSütü = new Nutrient() { NutrientName = " Yağsız İnek Sütü", Quantity = 1, NutrientCategory = sütÜrünleri, Scales = { new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 76 }, new Scale() { ScaleType = ScaleTypes.MLitre, UnitCalorie = 38 } } };
            context.Nutrients.Add(yağsızİnekSütü);

            Nutrient keçiSütü = new Nutrient() { NutrientName = " Keçi Sütü", Quantity = 1, NutrientCategory = sütÜrünleri, Scales = { new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 124 }, new Scale() { ScaleType = ScaleTypes.MLitre, UnitCalorie = 62 } } };
            context.Nutrients.Add(keçiSütü);

            Nutrient soyaSütü = new Nutrient() { NutrientName = " Soya Sütü", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 112 }, new Scale() { ScaleType = ScaleTypes.MLitre, UnitCalorie = 56 } } };
            context.Nutrients.Add(soyaSütü);

            Nutrient hindistanCeviziSütü = new Nutrient() { NutrientName = " Hindistan Cevizi Sütü", Quantity = 1, NutrientCategory = meyveGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 400 }, new Scale() { ScaleType = ScaleTypes.MLitre, UnitCalorie = 200 } } };
            context.Nutrients.Add(hindistanCeviziSütü);

            Nutrient yağlıKefir = new Nutrient() { NutrientName = "Tam Yağlı Sade Kefir", Quantity = 1, NutrientCategory = sütÜrünleri, Scales = { new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 120 }, new Scale() { ScaleType = ScaleTypes.MLitre, UnitCalorie = 60 } } };
            context.Nutrients.Add(yağlıKefir);

            Nutrient yağsızKefir = new Nutrient() { NutrientName = "Yağsız Sade Kefir", Quantity = 1, NutrientCategory = sütÜrünleri, Scales = { new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 74 }, new Scale() { ScaleType = ScaleTypes.MLitre, UnitCalorie = 37 } } };
            context.Nutrients.Add(yağsızKefir);

            Nutrient meyveliKefir = new Nutrient() { NutrientName = "Meyveli Kefir", Quantity = 1, NutrientCategory = sütÜrünleri, Scales = { new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 156 }, new Scale() { ScaleType = ScaleTypes.MLitre, UnitCalorie = 78 } } };
            context.Nutrients.Add(meyveliKefir);

            Nutrient cacık = new Nutrient() { NutrientName = "Cacık", Quantity = 1, NutrientCategory = sütÜrünleri, Scales = { new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 115 }, new Scale() { ScaleType = ScaleTypes.MLitre, UnitCalorie = 57.5 } } };
            context.Nutrients.Add(cacık);

            Nutrient bademSütü = new Nutrient() { NutrientName = "Badem Sütü", Quantity = 1, NutrientCategory = yağlıTohumlar, Scales = { new Scale() { ScaleType = ScaleTypes.SuBardağı, UnitCalorie = 48 }, new Scale() { ScaleType = ScaleTypes.MLitre, UnitCalorie = 24 } } };
            context.Nutrients.Add(bademSütü);

            //PEYNİRLER

            Nutrient beyazPeynir = new Nutrient() { NutrientName = "Beyaz Peynir (Yarım Yağlı İnek)", Quantity = 1, NutrientCategory = sütÜrünleri, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 60 }, new Scale() { ScaleType = ScaleTypes.Dilim, UnitCalorie = 30 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 200 } } };
            context.Nutrients.Add(beyazPeynir);

            Nutrient süzmePeynir = new Nutrient() { NutrientName = "Süzme Peynir", Quantity = 1, NutrientCategory = sütÜrünleri, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 69 }, new Scale() { ScaleType = ScaleTypes.Dilim, UnitCalorie = 34.5 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 230 } } };
            context.Nutrients.Add(süzmePeynir);

            Nutrient lorPeyniri = new Nutrient() { NutrientName = "Lor Peyniri", Quantity = 1, NutrientCategory = sütÜrünleri, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 43 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 14.33 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 86 } } };
            context.Nutrients.Add(lorPeyniri);

            Nutrient lightKaşarPeyniri = new Nutrient() { NutrientName = "Light Kaşar Peyniri", Quantity = 1, NutrientCategory = sütÜrünleri, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 75.3 }, new Scale() { ScaleType = ScaleTypes.Dilim, UnitCalorie = 75.3 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 251 } } };
            context.Nutrients.Add(lightKaşarPeyniri);

            Nutrient labnePeynir = new Nutrient() { NutrientName = "Tam Yağlı Labne Beyaz Peynir", Quantity = 1, NutrientCategory = sütÜrünleri, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 95.5 }, new Scale() { ScaleType = ScaleTypes.ÇorbaKaşığı, UnitCalorie = 95.5 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 191 } } };
            context.Nutrients.Add(labnePeynir);

            Nutrient örgüPeynir = new Nutrient() { NutrientName = "Örgü Peynir", Quantity = 1, NutrientCategory = sütÜrünleri, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 97.2 }, new Scale() { ScaleType = ScaleTypes.Dilim, UnitCalorie = 97.2 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 324 } } };
            context.Nutrients.Add(örgüPeynir);

            Nutrient dilPeyniri = new Nutrient() { NutrientName = "Tam Yağlı Dil Peyniri", Quantity = 1, NutrientCategory = sütÜrünleri, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 81 }, new Scale() { ScaleType = ScaleTypes.Dilim, UnitCalorie = 40.5 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 270 } } };
            context.Nutrients.Add(dilPeyniri);

            Nutrient mozarellaPeyniri = new Nutrient() { NutrientName = "Mozarella Peyniri", Quantity = 1, NutrientCategory = sütÜrünleri, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 90 }, new Scale() { ScaleType = ScaleTypes.Dilim, UnitCalorie = 45 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 300 } } };
            context.Nutrients.Add(mozarellaPeyniri);

            Nutrient hellimPeyniri = new Nutrient() { NutrientName = "Hellim Peyniri", Quantity = 1, NutrientCategory = sütÜrünleri, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 91.5 }, new Scale() { ScaleType = ScaleTypes.Dilim, UnitCalorie = 45.75 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 305 } } };
            context.Nutrients.Add(hellimPeyniri);

            //YOĞURTLAR
            Nutrient süzmeYoğurt = new Nutrient() { NutrientName = "Süzme Yoğurt", Quantity = 1, NutrientCategory = sütÜrünleri, Scales = { new Scale() { ScaleType = ScaleTypes.MLitre, UnitCalorie = 95 } } };
            context.Nutrients.Add(süzmeYoğurt);

            Nutrient tamYağlıYoğurt = new Nutrient() { NutrientName = "Tam Yağlı Yoğurt", Quantity = 1, NutrientCategory = sütÜrünleri, Scales = { new Scale() { ScaleType = ScaleTypes.MLitre, UnitCalorie = 87 } } };
            context.Nutrients.Add(tamYağlıYoğurt);

            Nutrient yağsızYoğurt = new Nutrient() { NutrientName = "Light Yoğurt", Quantity = 1, NutrientCategory = sütÜrünleri, Scales = { new Scale() { ScaleType = ScaleTypes.MLitre, UnitCalorie = 53 } } };
            context.Nutrients.Add(yağsızYoğurt);

            Nutrient meyveliYoğurt = new Nutrient() { NutrientName = "Meyveli Yoğurt", Quantity = 1, NutrientCategory = sütÜrünleri, Scales = { new Scale() { ScaleType = ScaleTypes.MLitre, UnitCalorie = 95 } } };
            context.Nutrients.Add(meyveliYoğurt);

            //RANDOM YEMEKLER
            Nutrient terbiyeliKöfte = new Nutrient() { NutrientName = "Terbiyeli Köfte", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 231 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 92.4 } } };
            context.Nutrients.Add(terbiyeliKöfte);

            Nutrient izmirKöfte = new Nutrient() { NutrientName = "İzmir Köfte", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 343 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 137.2 } } };
            context.Nutrients.Add(izmirKöfte);

            Nutrient çiğlikKöfte = new Nutrient() { NutrientName = "Çiğlik Köfte", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 303 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 121.2 } } };
            context.Nutrients.Add(çiğlikKöfte);

            Nutrient ızgaraKöfte = new Nutrient() { NutrientName = "Izgara Köfte", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 309 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 93.125 } } };
            context.Nutrients.Add(ızgaraKöfte);

            Nutrient kadınbuduKöfte = new Nutrient() { NutrientName = "KadınBudu Köfte", Quantity = 1, NutrientCategory = tahıl, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 417 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 208.5 } } };
            context.Nutrients.Add(kadınbuduKöfte);

            Nutrient tasKebabı = new Nutrient() { NutrientName = "Tas Kebabı", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 348 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 158.18 } } };
            context.Nutrients.Add(tasKebabı);

            Nutrient bahçevanKebabı = new Nutrient() { NutrientName = "Bahçevan Kebabı", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 339 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 135.6 } } };
            context.Nutrients.Add(bahçevanKebabı);

            Nutrient şehriyeliGüveç = new Nutrient() { NutrientName = "Şehriyeli Güveç", Quantity = 1, NutrientCategory = etveTahılGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 461 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 184.4 } } };
            context.Nutrients.Add(şehriyeliGüveç);

            Nutrient rostoEt = new Nutrient() { NutrientName = "Et Rosto", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 311 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 194.375 } } };
            context.Nutrients.Add(rostoEt);

            Nutrient söğütEtPüre = new Nutrient() { NutrientName = "Patates Püreli Söğüş Et", Quantity = 1, NutrientCategory = etveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 339 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 211.9 } } };
            context.Nutrients.Add(söğütEtPüre);

            Nutrient söğütEtSebze = new Nutrient() { NutrientName = "Sebzeli Söğüş Et", Quantity = 1, NutrientCategory = etveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 237 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 158 } } };
            context.Nutrients.Add(söğütEtSebze);

            Nutrient fırındaKoyunEti = new Nutrient() { NutrientName = "Fırında Koyun Eti Kızartma", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 293 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 146.5 } } };
            context.Nutrients.Add(fırındaKoyunEti);

            Nutrient patlıcanKebabı = new Nutrient() { NutrientName = "Patlıcan Kebabı", Quantity = 1, NutrientCategory = etveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 406 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 162.4 } } };
            context.Nutrients.Add(patlıcanKebabı);

            Nutrient haşlamaTavuk = new Nutrient() { NutrientName = "Haşlama Tavuk", Quantity = 1, NutrientCategory = etÜrünleriveYumurta, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 259 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 103.6 } } };
            context.Nutrients.Add(haşlamaTavuk);

            Nutrient kıymalıYaprakSarma = new Nutrient() { NutrientName = "Kıymalı Yaprak Sarma", Quantity = 1, NutrientCategory = etveTahılGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 300 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 200 } } };
            context.Nutrients.Add(kıymalıYaprakSarma);

            Nutrient kıymalıPatates = new Nutrient() { NutrientName = "Kıymalı Patates", Quantity = 1, NutrientCategory = etveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 250 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 100 } } };
            context.Nutrients.Add(kıymalıPatates);

            Nutrient yumurtalıIspanak = new Nutrient() { NutrientName = "YumurtalıIspanak", Quantity = 1, NutrientCategory = etveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 206 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 114.44 } } };
            context.Nutrients.Add(yumurtalıIspanak);

            Nutrient patlıcanMusakka = new Nutrient() { NutrientName = "Patlıcan Musakka", Quantity = 1, NutrientCategory = etveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 201 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 80.4 } } };
            context.Nutrients.Add(patlıcanMusakka);

            Nutrient kıymalıKapuska = new Nutrient() { NutrientName = "Kıymalı Kapuska", Quantity = 1, NutrientCategory = etveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 190 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 82.61 } } };
            context.Nutrients.Add(kıymalıKapuska);

            Nutrient karnıyarık = new Nutrient() { NutrientName = "Karnıyarık", Quantity = 1, NutrientCategory = etveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 270 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 122.72 } } };
            context.Nutrients.Add(karnıyarık);

            Nutrient imambayıldı = new Nutrient() { NutrientName = "İmambayıldı", Quantity = 1, NutrientCategory = etveSebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 194 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 130 } } };
            context.Nutrients.Add(imambayıldı);

            Nutrient yoğurtluKarnabaharKızart = new Nutrient() { NutrientName = "Yoğurtlu Karnabahar Kızartması", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 248 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 177 } } };
            context.Nutrients.Add(yoğurtluKarnabaharKızart);

            Nutrient yoğurtluPatlıcanKızart = new Nutrient() { NutrientName = "Yoğurtlu Patlıcan Kızartması", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 248 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 177 } } };
            context.Nutrients.Add(yoğurtluPatlıcanKızart);

            Nutrient yoğurtluHavuçKızart = new Nutrient() { NutrientName = "Yoğurtlu Havuç Kızartması", Quantity = 1, NutrientCategory = sebzeGrubu, Scales = { new Scale() { ScaleType = ScaleTypes.Porsiyon, UnitCalorie = 267 }, new Scale() { ScaleType = ScaleTypes.Gram, UnitCalorie = 178 } } };
            context.Nutrients.Add(yoğurtluHavuçKızart);



        }
    }
}
