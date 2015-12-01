﻿using NUnit.Framework;

namespace Nuve.Test.Analysis
{
    [TestFixture]
    internal class VerbConjugationTest
    {
        [TestCase("geldim", "gel/FIIL DU/FC_ZAMAN_GECMIS_DU m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("geldin", "gel/FIIL DU/FC_ZAMAN_GECMIS_DU n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("geldi", "gel/FIIL DU/FC_ZAMAN_GECMIS_DU")]
        [TestCase("geldik", "gel/FIIL DU/FC_ZAMAN_GECMIS_DU k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("geldiniz", "gel/FIIL DU/FC_ZAMAN_GECMIS_DU nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("geldiler", "gel/FIIL DU/FC_ZAMAN_GECMIS_DU lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        public void GecmisDiOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmedim", "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gelmedin", "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gelmedi", "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU")]
        [TestCase("gelmedik", "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelmediniz", "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("gelmediler", "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        public void GecmisDiOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("geldim mi", "gel/FIIL DU/FC_ZAMAN_GECMIS_DU m/EKFIIL_SAHIS_BEN_m _mU/SORU_mU")]
        [TestCase("geldin mi", "gel/FIIL DU/FC_ZAMAN_GECMIS_DU n/EKFIIL_SAHIS_SEN_n _mU/SORU_mU")]
        [TestCase("geldi mi", "gel/FIIL DU/FC_ZAMAN_GECMIS_DU _mU/SORU_mU")]
        [TestCase("geldik mi", "gel/FIIL DU/FC_ZAMAN_GECMIS_DU k/EKFIIL_SAHIS_BIZ_k _mU/SORU_mU")]
        [TestCase("geldiniz mi", "gel/FIIL DU/FC_ZAMAN_GECMIS_DU nUz/EKFIIL_SAHIS_SIZ_nUz _mU/SORU_mU")]
        [TestCase("geldiler mi", "gel/FIIL DU/FC_ZAMAN_GECMIS_DU lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU")]
        public void GecmisDiSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmedim mi", "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU m/EKFIIL_SAHIS_BEN_m _mU/SORU_mU")]
        [TestCase("gelmedin mi", "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU n/EKFIIL_SAHIS_SEN_n _mU/SORU_mU")]
        [TestCase("gelmedi mi", "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU _mU/SORU_mU")]
        [TestCase("gelmedik mi", "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU k/EKFIIL_SAHIS_BIZ_k _mU/SORU_mU")]
        [TestCase("gelmediniz mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU nUz/EKFIIL_SAHIS_SIZ_nUz _mU/SORU_mU")]
        [TestCase("gelmediler mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU")]
        public void GecmisDiSoruOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmişim", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("gelmişsin", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gelmiş", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş")]
        [TestCase("gelmişiz", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("gelmişsiniz", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("gelmişler", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        public void GecmisMisOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmemişim", "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("gelmemişsin", "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gelmemiş", "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş")]
        [TestCase("gelmemişiz", "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("gelmemişsiniz", "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("gelmemişler", "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        public void GecmisMisOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmiş miyim", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş _mU/SORU_mU yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("gelmiş misin", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş _mU/SORU_mU sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gelmiş mi", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş _mU/SORU_mU")]
        [TestCase("gelmiş miyiz", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş _mU/SORU_mU yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("gelmiş misiniz", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş _mU/SORU_mU sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("gelmişler mi", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU")]
        public void GecmisMisSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmemiş miyim",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş _mU/SORU_mU yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("gelmemiş misin",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş _mU/SORU_mU sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gelmemiş mi", "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş _mU/SORU_mU")]
        [TestCase("gelmemiş miyiz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş _mU/SORU_mU yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("gelmemiş misiniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş _mU/SORU_mU sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("gelmemişler mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU")]
        public void GecmisMisSoruOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("geliyorum", "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("geliyorsun", "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("geliyor", "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor")]
        [TestCase("geliyoruz", "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("geliyorsunuz", "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("geliyorlar", "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        public void SimdikiZamanOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmiyorum", "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("gelmiyorsun", "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gelmiyor", "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor")]
        [TestCase("gelmiyoruz", "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("gelmiyorsunuz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("gelmiyorlar", "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor lAr/EKFIIL_SAHIS_ONLAR_lAr")
        ]
        public void SimdikiZamanOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("geliyor muyum", "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("geliyor musun", "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("geliyor mu", "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU")]
        [TestCase("geliyor muyuz", "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("geliyor musunuz", "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("geliyorlar mı", "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU")]
        public void SimdikiZamanSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmiyor muyum",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("gelmiyor musun",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gelmiyor mu", "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU")]
        [TestCase("gelmiyor muyuz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("gelmiyor musunuz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("gelmiyorlar mı",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU")]
        public void SimdikiZamanSoruOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }


        [TestCase("arıyor", "ara/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor")]
        [TestCase("ödüyor", "öde/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor")]
        [TestCase("yiyor", "ye/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor")]
        [TestCase("diyor", "de/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor")]
        [TestCase("acıyor", "acı/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor")]
        [TestCase("eriyor", "er/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor")]
        [TestCase("okuyor", "oku/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor")]
        [TestCase("üşüyor", "üşü/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor")]
        [TestCase("ediyor", "et/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor")]
        [TestCase("atıyor", "at/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor")]
        [TestCase("kılıyor", "kıl/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor")]
        [TestCase("biliyor", "bil/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor")]
        [TestCase("buluyor", "bul/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor")]
        [TestCase("yüzüyor", "yüz/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor")]
        [TestCase("oluyor", "ol/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor")]
        [TestCase("ölüyor", "öl/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor")]
        [TestCase("kalıyor", "kal/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor")]
        [TestCase("geliyor", "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor")]
        [TestCase("yapıyor", "yap/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor")]
        [TestCase("gözlüyor", "göz/ISIM lA/IY_FIIL_lA Uyor/FC_ZAMAN_SIMDIKI_(U)yor")]
        [TestCase("kolluyor", "kol/ISIM lA/IY_FIIL_lA Uyor/FC_ZAMAN_SIMDIKI_(U)yor")]
        public void SimdikiZamanOrtografiTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }


        [TestCase("geleceğim", "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("geleceksin", "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gelecek", "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK")]
        [TestCase("geleceğiz", "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("geleceksiniz", "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("gelecekler", "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        public void GelecekOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmeyeceğim",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("gelmeyeceksin",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gelmeyecek", "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK")]
        [TestCase("gelmeyeceğiz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("gelmeyeceksiniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("gelmeyecekler",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        public void GelecekOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelecek miyim", "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("gelecek misin", "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gelecek mi", "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU")]
        [TestCase("gelecek miyiz", "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("gelecek misiniz", "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")
        ]
        [TestCase("gelecekler mi", "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU")]
        public void GelecekSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmeyecek miyim", "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU " +
                                      "yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("gelmeyecek misin", "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU " +
                                      "sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gelmeyecek mi", "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU")]
        [TestCase("gelmeyecek miyiz", "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU " +
                                      "yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("gelmeyecek misiniz", "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU " +
                                        "sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("gelmeyecekler mi", "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK " +
                                      "lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU")]
        public void GelecekSoruOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("yaparım", "yap/FIIL Ur/FC_ZAMAN_GENIS_(U)r yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("yaparsın", "yap/FIIL Ur/FC_ZAMAN_GENIS_(U)r sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("yapar", "yap/FIIL Ur/FC_ZAMAN_GENIS_(U)r")]
        [TestCase("yaparız", "yap/FIIL Ur/FC_ZAMAN_GENIS_(U)r yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("yaparsınız", "yap/FIIL Ur/FC_ZAMAN_GENIS_(U)r sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("yaparlar", "yap/FIIL Ur/FC_ZAMAN_GENIS_(U)r lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        public void GenisOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("yapmam", "yap/FIIL mA/FY_OLUMSUZLUK_mA m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("yapmazsın", "yap/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("yapmaz", "yap/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r")]
        [TestCase("yapmayız", "yap/FIIL mA/FY_OLUMSUZLUK_mA yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("yapmazsınız", "yap/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("yapmazlar", "yap/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        public void GenisOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("yapar mıyım", "yap/FIIL Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("yapar mısın", "yap/FIIL Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("yapar mı", "yap/FIIL Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU")]
        [TestCase("yapar mıyız", "yap/FIIL Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("yapar mısınız", "yap/FIIL Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("yaparlar mı", "yap/FIIL Ur/FC_ZAMAN_GENIS_(U)r lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU")]
        public void GenisSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("yapmaz mıyım",
            "yap/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("yapmaz mısın",
            "yap/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("yapmaz mı", "yap/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU")]
        [TestCase("yapmaz mıyız",
            "yap/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("yapmaz mısınız",
            "yap/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("yapmazlar mı",
            "yap/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU")]
        public void GenisSoruOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }


        [TestCase("arar", "ara/FIIL Ur/FC_ZAMAN_GENIS_(U)r")]
        [TestCase("öder", "öde/FIIL Ur/FC_ZAMAN_GENIS_(U)r")]
        [TestCase("yer", "ye/FIIL Ur/FC_ZAMAN_GENIS_(U)r")]
        [TestCase("der", "de/FIIL Ur/FC_ZAMAN_GENIS_(U)r")]
        [TestCase("acır", "acı/FIIL Ur/FC_ZAMAN_GENIS_(U)r")]
        [TestCase("erir", "eri/FIIL Ur/FC_ZAMAN_GENIS_(U)r")]
        [TestCase("okur", "oku/FIIL Ur/FC_ZAMAN_GENIS_(U)r")]
        [TestCase("üşür", "üşü/FIIL Ur/FC_ZAMAN_GENIS_(U)r")]
        [TestCase("eder", "et/FIIL Ur/FC_ZAMAN_GENIS_(U)r")]
        [TestCase("atar", "at/FIIL Ur/FC_ZAMAN_GENIS_(U)r")]
        [TestCase("kılar", "kıl/FIIL Ur/FC_ZAMAN_GENIS_(U)r")]
        [TestCase("bilir", "bil/FIIL Ur/FC_ZAMAN_GENIS_(U)r")]
        [TestCase("bulur", "bul/FIIL Ur/FC_ZAMAN_GENIS_(U)r")]
        [TestCase("yüzer", "yüz/FIIL Ur/FC_ZAMAN_GENIS_(U)r")]
        [TestCase("olur", "ol/FIIL Ur/FC_ZAMAN_GENIS_(U)r")]
        [TestCase("ölür", "öl/FIIL Ur/FC_ZAMAN_GENIS_(U)r")]
        [TestCase("kalır", "kal/FIIL Ur/FC_ZAMAN_GENIS_(U)r")]
        [TestCase("gelir", "gel/FIIL Ur/FC_ZAMAN_GENIS_(U)r")]
        [TestCase("yapar", "yap/FIIL Ur/FC_ZAMAN_GENIS_(U)r")]
        [TestCase("gözler", "göz/ISIM lA/IY_FIIL_lA Ur/FC_ZAMAN_GENIS_(U)r")]
        [TestCase("kollar", "kol/ISIM lA/IY_FIIL_lA Ur/FC_ZAMAN_GENIS_(U)r")]
        public void GenisOrtografiTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }


        [TestCase("gelmeliyim", "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("gelmelisin", "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gelmeli", "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI")]
        [TestCase("gelmeliyiz", "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("gelmelisiniz", "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("gelmeliler", "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        public void GereklilikOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmemeliyim", "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI yUm/EKFIIL_SAHIS_BEN_(y)Um")
        ]
        [TestCase("gelmemelisin", "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gelmemeli", "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI")]
        [TestCase("gelmemeliyiz", "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI yUz/EKFIIL_SAHIS_BIZ_(y)Uz")
        ]
        [TestCase("gelmemelisiniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("gelmemeliler", "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI lAr/EKFIIL_SAHIS_ONLAR_lAr")
        ]
        public void GereklilikOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmeli miyim", "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("gelmeli misin", "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gelmeli mi", "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU")]
        [TestCase("gelmeli miyiz", "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("gelmeli misiniz", "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("gelmeliler mi", "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU")]
        public void GereklilikSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmemeli miyim",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("gelmemeli misin",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gelmemeli mi", "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU")]
        [TestCase("gelmemeli miyiz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("gelmemeli misiniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("gelmemeliler mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU")]
        public void GereklilikSoruOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelsem", "gel/FIIL sA/FC_KIP_DILEK_sA m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gelsen", "gel/FIIL sA/FC_KIP_DILEK_sA n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gelse", "gel/FIIL sA/FC_KIP_DILEK_sA")]
        [TestCase("gelsek", "gel/FIIL sA/FC_KIP_DILEK_sA k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelseniz", "gel/FIIL sA/FC_KIP_DILEK_sA nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("gelseler", "gel/FIIL sA/FC_KIP_DILEK_sA lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        public void DilekOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmesem", "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gelmesen", "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gelmese", "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA")]
        [TestCase("gelmesek", "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelmeseniz", "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("gelmeseler", "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        public void DilekOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelsem mi", "gel/FIIL sA/FC_KIP_DILEK_sA m/EKFIIL_SAHIS_BEN_m _mU/SORU_mU")]
        [TestCase("gelsen mi", "gel/FIIL sA/FC_KIP_DILEK_sA n/EKFIIL_SAHIS_SEN_n _mU/SORU_mU")]
        [TestCase("gelse mi", "gel/FIIL sA/FC_KIP_DILEK_sA _mU/SORU_mU")]
        [TestCase("gelsek mi", "gel/FIIL sA/FC_KIP_DILEK_sA k/EKFIIL_SAHIS_BIZ_k _mU/SORU_mU")]
        [TestCase("gelseniz mi", "gel/FIIL sA/FC_KIP_DILEK_sA nUz/EKFIIL_SAHIS_SIZ_nUz _mU/SORU_mU")]
        [TestCase("gelseler mi", "gel/FIIL sA/FC_KIP_DILEK_sA lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU")]
        public void DilekSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmesem mi", "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA m/EKFIIL_SAHIS_BEN_m _mU/SORU_mU")]
        [TestCase("gelmesen mi", "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA n/EKFIIL_SAHIS_SEN_n _mU/SORU_mU")]
        [TestCase("gelmese mi", "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA _mU/SORU_mU")]
        [TestCase("gelmesek mi", "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA k/EKFIIL_SAHIS_BIZ_k _mU/SORU_mU")]
        [TestCase("gelmeseniz mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA nUz/EKFIIL_SAHIS_SIZ_nUz _mU/SORU_mU")]
        [TestCase("gelmeseler mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU")]
        public void DilekSoruOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("geleyim", "gel/FIIL yA/FC_KIP_ISTEK_(y)A yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("gelesin", "gel/FIIL yA/FC_KIP_ISTEK_(y)A sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gele", "gel/FIIL yA/FC_KIP_ISTEK_(y)A")]
        [TestCase("gelelim", "gel/FIIL yA/FC_KIP_ISTEK_(y)A k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelesiniz", "gel/FIIL yA/FC_KIP_ISTEK_(y)A sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("geleler", "gel/FIIL yA/FC_KIP_ISTEK_(y)A lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("gelsene", "gel/FIIL sAnA/FC_KIP_ISTEK_sAnA")]
        [TestCase("gelsenize", "gel/FIIL sAnIzA/FC_KIP_ISTEK_sAnIzA")]
        public void IstekOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmeyeyim", "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("gelmeyesin", "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gelmeye", "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A")]
        [TestCase("gelmeyelim", "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelmeyesiniz", "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("gelmeyeler", "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("gelmesene", "gel/FIIL mA/FY_OLUMSUZLUK_mA sAnA/FC_KIP_ISTEK_sAnA")]
        [TestCase("gelmesenize", "gel/FIIL mA/FY_OLUMSUZLUK_mA sAnIzA/FC_KIP_ISTEK_sAnIzA")]
        public void IstekOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("geleyim mi", "gel/FIIL yA/FC_KIP_ISTEK_(y)A yUm/EKFIIL_SAHIS_BEN_(y)Um _mU/SORU_mU")]
        [TestCase("gelelim mi", "gel/FIIL yA/FC_KIP_ISTEK_(y)A k/EKFIIL_SAHIS_BIZ_k _mU/SORU_mU")]
        public void IstekSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmeyeyim mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A yUm/EKFIIL_SAHIS_BEN_(y)Um _mU/SORU_mU")]
        [TestCase("gelmeyelim mi", "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A k/EKFIIL_SAHIS_BIZ_k _mU/SORU_mU")
        ]
        public void IstekSoruOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gel", "gel/FIIL")]
        [TestCase("gelsin", "gel/FIIL sUn/FC_KIP_EMIR_sUn")]
        [TestCase("gelin", "gel/FIIL yUn/FC_KIP_EMIR_(y)Un")]
        [TestCase("geliniz", "gel/FIIL yUnUz/FC_KIP_EMIR_(y)UnUz")]
        [TestCase("gelsinler", "gel/FIIL sUnlAr/FC_KIP_EMIR_sUnlAr")]
        public void EmirOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelme", "gel/FIIL mA/FY_OLUMSUZLUK_mA")]
        [TestCase("gelmeyin", "gel/FIIL mA/FY_OLUMSUZLUK_mA yUn/FC_KIP_EMIR_(y)Un")]
        [TestCase("gelmesin", "gel/FIIL mA/FY_OLUMSUZLUK_mA sUn/FC_KIP_EMIR_sUn")]
        [TestCase("gelmeyiniz", "gel/FIIL mA/FY_OLUMSUZLUK_mA yUnUz/FC_KIP_EMIR_(y)UnUz")]
        [TestCase("gelmesinler", "gel/FIIL mA/FY_OLUMSUZLUK_mA sUnlAr/FC_KIP_EMIR_sUnlAr")]
        public void EmirOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelsin mi", "gel/FIIL sUn/FC_KIP_EMIR_sUn _mU/SORU_mU")]
        [TestCase("gelsinler mi", "gel/FIIL sUnlAr/FC_KIP_EMIR_sUnlAr _mU/SORU_mU")]
        public void EmirSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmesin mi", "gel/FIIL mA/FY_OLUMSUZLUK_mA sUn/FC_KIP_EMIR_sUn _mU/SORU_mU")]
        [TestCase("gelmesinler mi", "gel/FIIL mA/FY_OLUMSUZLUK_mA sUnlAr/FC_KIP_EMIR_sUnlAr _mU/SORU_mU")]
        public void EmirOlumsuzSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("geldiydim", "gel/FIIL DU/FC_ZAMAN_GECMIS_DU yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("geldiydin", "gel/FIIL DU/FC_ZAMAN_GECMIS_DU yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("geldiydi", "gel/FIIL DU/FC_ZAMAN_GECMIS_DU yDU/EKFIIL_HIKAYE_(y)DU")]
        [TestCase("geldiydik", "gel/FIIL DU/FC_ZAMAN_GECMIS_DU yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("geldiydiniz", "gel/FIIL DU/FC_ZAMAN_GECMIS_DU yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("geldiydiler", "gel/FIIL DU/FC_ZAMAN_GECMIS_DU yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        public void GecmisDiHikayeOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmediydim",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gelmediydin",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gelmediydi", "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU yDU/EKFIIL_HIKAYE_(y)DU")]
        [TestCase("gelmediydik",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelmediydiniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("gelmediydiler",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        public void GecmisDiHikayeOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("geldi miydim",
            "gel/FIIL DU/FC_ZAMAN_GECMIS_DU _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("geldi miydin",
            "gel/FIIL DU/FC_ZAMAN_GECMIS_DU _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("geldi miydi", "gel/FIIL DU/FC_ZAMAN_GECMIS_DU _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU")]
        [TestCase("geldi miydik",
            "gel/FIIL DU/FC_ZAMAN_GECMIS_DU _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("geldi miydiniz",
            "gel/FIIL DU/FC_ZAMAN_GECMIS_DU _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("geldi miydiler",
            "gel/FIIL DU/FC_ZAMAN_GECMIS_DU _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("geldiler miydi",
            "gel/FIIL DU/FC_ZAMAN_GECMIS_DU lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU")]
        public void GecmisDiHikayeSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmedi miydim",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m"
            )]
        [TestCase("gelmedi miydin",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n"
            )]
        [TestCase("gelmedi miydi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU")]
        [TestCase("gelmedi miydik",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k"
            )]
        [TestCase("gelmedi miydiniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz"
            )]
        [TestCase("gelmedi miydiler",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr"
            )]
        [TestCase("gelmediler miydi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU"
            )]
        public void GecmisDiHikayeSoruOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmiştim", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gelmiştin", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gelmişti", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş yDU/EKFIIL_HIKAYE_(y)DU")]
        [TestCase("gelmiştik", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelmiştiniz", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("gelmiştiler", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("gelmişlerdi", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş lAr/EKFIIL_SAHIS_ONLAR_lAr yDU/EKFIIL_HIKAYE_(y)DU")]
        public void GecmisMisHikayeOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmemiştim",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gelmemiştin",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gelmemişti", "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş yDU/EKFIIL_HIKAYE_(y)DU")]
        [TestCase("gelmemiştik",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelmemiştiniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("gelmemiştiler",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("gelmemişlerdi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş lAr/EKFIIL_SAHIS_ONLAR_lAr yDU/EKFIIL_HIKAYE_(y)DU")]
        public void GecmisMisHikayeOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmiş miydim",
            "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gelmiş miydin",
            "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gelmiş miydi", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU")]
        [TestCase("gelmiş miydik",
            "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelmiş miydiniz",
            "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("gelmişler miydi",
            "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU")]
        public void GecmisMisHikayeSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("geliyordum", "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("geliyordun", "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("geliyordu", "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor yDU/EKFIIL_HIKAYE_(y)DU")]
        [TestCase("geliyorduk", "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("geliyordunuz",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("geliyordular",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("geliyorlardı",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor lAr/EKFIIL_SAHIS_ONLAR_lAr yDU/EKFIIL_HIKAYE_(y)DU")]
        public void SimdikiHikayeOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmiyordum",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gelmiyordun",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gelmiyordu", "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor yDU/EKFIIL_HIKAYE_(y)DU")]
        [TestCase("gelmiyorduk",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelmiyordunuz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz"
            )]
        [TestCase("gelmiyordular",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr"
            )]
        [TestCase("gelmiyorlardı",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor lAr/EKFIIL_SAHIS_ONLAR_lAr yDU/EKFIIL_HIKAYE_(y)DU"
            )]
        public void SimdikiHikayeOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("geliyor muydum",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("geliyor muydun",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("geliyor muydu", "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU")]
        [TestCase("geliyor muyduk",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("geliyor muydunuz",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("geliyor muydular",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("geliyorlar mıydı",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU")]
        public void SimdikiHikayeSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmiyor muydum",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m"
            )]
        [TestCase("gelmiyor muydun",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n"
            )]
        [TestCase("gelmiyor muydu",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU")]
        [TestCase("gelmiyor muyduk",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k"
            )]
        [TestCase("gelmiyor muydunuz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz"
            )]
        [TestCase("geliyor muydular",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("gelmiyorlar mıydı",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU"
            )]
        public void SimdikiHikayeSoruOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelecektim", "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gelecektin", "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gelecekti", "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK yDU/EKFIIL_HIKAYE_(y)DU")]
        [TestCase("gelecektik", "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelecektiniz",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("gelecektiler",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("geleceklerdi",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK lAr/EKFIIL_SAHIS_ONLAR_lAr yDU/EKFIIL_HIKAYE_(y)DU")]
        public void GelecekHikayeOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmeyecektim",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gelmeyecektin",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gelmeyecekti", "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK yDU/EKFIIL_HIKAYE_(y)DU")
        ]
        [TestCase("gelmeyecektik",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelmeyecektiniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz"
            )]
        [TestCase("gelmeyecektiler",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr"
            )]
        [TestCase("gelmeyeceklerdi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK lAr/EKFIIL_SAHIS_ONLAR_lAr yDU/EKFIIL_HIKAYE_(y)DU"
            )]
        public void GelecekHikayeOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelecek miydim",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gelecek miydin",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gelecek miydi", "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU")]
        [TestCase("gelecek miydik",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelecek miydiniz",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("gelecek miydiler",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("gelecekler miydi",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU")]
        public void GelecekHikayeSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmeyecek miydim",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m"
            )]
        [TestCase("gelmeyecek miydin",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n"
            )]
        [TestCase("gelmeyecek miydi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU")]
        [TestCase("gelmeyecek miydik",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k"
            )]
        [TestCase("gelmeyecek miydiniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz"
            )]
        [TestCase("gelmeyecek miydiler",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr"
            )]
        [TestCase("gelmeyecekler miydi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU"
            )]
        public void GelecekHikayeSoruOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gezerdim", "gez/FIIL Ur/FC_ZAMAN_GENIS_(U)r yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gezerdin", "gez/FIIL Ur/FC_ZAMAN_GENIS_(U)r yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gezerdi", "gez/FIIL Ur/FC_ZAMAN_GENIS_(U)r yDU/EKFIIL_HIKAYE_(y)DU")]
        [TestCase("gezerdik", "gez/FIIL Ur/FC_ZAMAN_GENIS_(U)r yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gezerdiniz", "gez/FIIL Ur/FC_ZAMAN_GENIS_(U)r yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("gezerdiler", "gez/FIIL Ur/FC_ZAMAN_GENIS_(U)r yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("gezerlerdi", "gez/FIIL Ur/FC_ZAMAN_GENIS_(U)r lAr/EKFIIL_SAHIS_ONLAR_lAr yDU/EKFIIL_HIKAYE_(y)DU")]
        public void GenisHikayeOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gezmezdim",
            "gez/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gezmezdin",
            "gez/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gezmezdi", "gez/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r yDU/EKFIIL_HIKAYE_(y)DU")]
        [TestCase("gezmezdik",
            "gez/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gezmezdiniz",
            "gez/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("gezmezdiler",
            "gez/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("gezmezlerdi",
            "gez/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r lAr/EKFIIL_SAHIS_ONLAR_lAr yDU/EKFIIL_HIKAYE_(y)DU")]
        public void GenisHikayeOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gezer miydim",
            "gez/FIIL Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gezer miydin",
            "gez/FIIL Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gezer miydi", "gez/FIIL Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU")]
        [TestCase("gezer miydik",
            "gez/FIIL Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gezer miydiniz",
            "gez/FIIL Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("gezer miydiler",
            "gez/FIIL Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("gezerler miydi",
            "gez/FIIL Ur/FC_ZAMAN_GENIS_(U)r lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU")]
        public void GenisHikayeSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gezmez miydim",
            "gez/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m"
            )]
        [TestCase("gezmez miydin",
            "gez/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n"
            )]
        [TestCase("gezmez miydi",
            "gez/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU")]
        [TestCase("gezmez miydik",
            "gez/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k"
            )]
        [TestCase("gezmez miydiniz",
            "gez/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz"
            )]
        [TestCase("gezmez miydiler",
            "gez/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr"
            )]
        [TestCase("gezmezler miydi",
            "gez/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU"
            )]
        public void GenisHikayeSoruOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmeliydim", "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gelmeliydin", "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gelmeliydi", "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI yDU/EKFIIL_HIKAYE_(y)DU")]
        [TestCase("gelmeliydik", "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelmeliydiniz",
            "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("gelmeliydiler",
            "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        public void GereklilikHikayeOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmemeliydim",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gelmemeliydin",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gelmemeliydi", "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI yDU/EKFIIL_HIKAYE_(y)DU")]
        [TestCase("gelmemeliydik",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelmemeliydiniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz")
        ]
        [TestCase("gelmemeliydiler",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr"
            )]
        public void GereklilikHikayeOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmeli miydim",
            "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gelmeli miydin",
            "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gelmeli miydi", "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU")]
        [TestCase("gelmeli miydik",
            "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelmeli miydiniz",
            "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("gelmeli miydiler",
            "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        public void GereklilikHikayeSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmemeli miydim",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m"
            )]
        [TestCase("gelmemeli miydin",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n"
            )]
        [TestCase("gelmemeli miydi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU")]
        [TestCase("gelmemeli miydik",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k"
            )]
        [TestCase("gelmemeli miydiniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz"
            )]
        [TestCase("gelmemeli miydiler",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr"
            )]
        public void GereklilikHikayeSoruOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelseydim", "gel/FIIL sA/FC_KIP_DILEK_sA yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gelseydin", "gel/FIIL sA/FC_KIP_DILEK_sA yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gelseydi", "gel/FIIL sA/FC_KIP_DILEK_sA yDU/EKFIIL_HIKAYE_(y)DU")]
        [TestCase("gelseydik", "gel/FIIL sA/FC_KIP_DILEK_sA yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelseydiniz", "gel/FIIL sA/FC_KIP_DILEK_sA yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("gelseydiler", "gel/FIIL sA/FC_KIP_DILEK_sA yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("gelselerdi", "gel/FIIL sA/FC_KIP_DILEK_sA lAr/EKFIIL_SAHIS_ONLAR_lAr yDU/EKFIIL_HIKAYE_(y)DU")]
        public void DilekHikayeOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmeseydim",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gelmeseydin",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gelmeseydi", "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA yDU/EKFIIL_HIKAYE_(y)DU")]
        [TestCase("gelmeseydik",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelmeseydiniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("gelmeseydiler",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("gelmeselerdi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA lAr/EKFIIL_SAHIS_ONLAR_lAr yDU/EKFIIL_HIKAYE_(y)DU")]
        public void DilekHikayeOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelse miydim", "gel/FIIL sA/FC_KIP_DILEK_sA _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m"
            )]
        [TestCase("gelse miydin", "gel/FIIL sA/FC_KIP_DILEK_sA _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n"
            )]
        [TestCase("gelse miydi", "gel/FIIL sA/FC_KIP_DILEK_sA _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU")]
        [TestCase("gelse miydik", "gel/FIIL sA/FC_KIP_DILEK_sA _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k"
            )]
        [TestCase("gelse miydiniz",
            "gel/FIIL sA/FC_KIP_DILEK_sA _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("gelse miydiler",
            "gel/FIIL sA/FC_KIP_DILEK_sA _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("gelseler miydi",
            "gel/FIIL sA/FC_KIP_DILEK_sA lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU")]
        public void DilekHikayeSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmese miydim",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gelmese miydin",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gelmese miydi", "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU"
            )]
        [TestCase("gelmese miydik",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelmese miydiniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz"
            )]
        [TestCase("gelmese miydiler",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr"
            )]
        [TestCase("gelmeseler miydi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU"
            )]
        public void DilekHikayeSoruOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("geleydim", "gel/FIIL yA/FC_KIP_ISTEK_(y)A yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("geleydin", "gel/FIIL yA/FC_KIP_ISTEK_(y)A yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("geleydi", "gel/FIIL yA/FC_KIP_ISTEK_(y)A yDU/EKFIIL_HIKAYE_(y)DU")]
        [TestCase("geleydik", "gel/FIIL yA/FC_KIP_ISTEK_(y)A yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("geleydiniz", "gel/FIIL yA/FC_KIP_ISTEK_(y)A yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("geleydiler", "gel/FIIL yA/FC_KIP_ISTEK_(y)A yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        public void IstekHikayeOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmeyeydim",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gelmeyeydin",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gelmeyeydi", "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A yDU/EKFIIL_HIKAYE_(y)DU")]
        [TestCase("gelmeyeydik",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelmeyeydiniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("gelmeyeydiler",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        public void IstekHikayeOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gele miydim",
            "gel/FIIL yA/FC_KIP_ISTEK_(y)A _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gele miydin",
            "gel/FIIL yA/FC_KIP_ISTEK_(y)A _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gele miydi", "gel/FIIL yA/FC_KIP_ISTEK_(y)A _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU")]
        [TestCase("gele miydik",
            "gel/FIIL yA/FC_KIP_ISTEK_(y)A _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gele miydiniz",
            "gel/FIIL yA/FC_KIP_ISTEK_(y)A _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("gele miydiler",
            "gel/FIIL yA/FC_KIP_ISTEK_(y)A _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        public void IstekHikayeSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmeye miydim",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU m/EKFIIL_SAHIS_BEN_m"
            )]
        [TestCase("gelmeye miydin",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU n/EKFIIL_SAHIS_SEN_n"
            )]
        [TestCase("gelmeye miydi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU")]
        [TestCase("gelmeye miydik",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU k/EKFIIL_SAHIS_BIZ_k"
            )]
        [TestCase("gelmeye miydiniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU nUz/EKFIIL_SAHIS_SIZ_nUz"
            )]
        [TestCase("gelmeye miydiler",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A _mU/SORU_mU yDU/EKFIIL_HIKAYE_(y)DU lAr/EKFIIL_SAHIS_ONLAR_lAr"
            )]
        public void IstekHikayeSoruOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmişmişim",
            "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş ymUş/EKFIIL_RIVAYET_(y)mUş yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("gelmişmişsin", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş ymUş/EKFIIL_RIVAYET_(y)mUş sUn/EKFIIL_SAHIS_SEN_sUn"
            )]
        [TestCase("gelmişmiş", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş ymUş/EKFIIL_RIVAYET_(y)mUş")]
        [TestCase("gelmişmişiz",
            "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş ymUş/EKFIIL_RIVAYET_(y)mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("gelmişmişsiniz",
            "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş ymUş/EKFIIL_RIVAYET_(y)mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("gelmişmişler",
            "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş ymUş/EKFIIL_RIVAYET_(y)mUş lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("gelmişlermiş",
            "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş lAr/EKFIIL_SAHIS_ONLAR_lAr ymUş/EKFIIL_RIVAYET_(y)mUş")]
        public void GecmisMisRivayetOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmemişmişim",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş ymUş/EKFIIL_RIVAYET_(y)mUş yUm/EKFIIL_SAHIS_BEN_(y)Um"
            )]
        [TestCase("gelmemişmişsin",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş ymUş/EKFIIL_RIVAYET_(y)mUş sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gelmemişmiş", "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş ymUş/EKFIIL_RIVAYET_(y)mUş")]
        [TestCase("gelmemişmişiz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş ymUş/EKFIIL_RIVAYET_(y)mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz"
            )]
        [TestCase("gelmemişmişsiniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş ymUş/EKFIIL_RIVAYET_(y)mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz"
            )]
        [TestCase("gelmemişmişler",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş ymUş/EKFIIL_RIVAYET_(y)mUş lAr/EKFIIL_SAHIS_ONLAR_lAr"
            )]
        [TestCase("gelmemişlermiş",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş lAr/EKFIIL_SAHIS_ONLAR_lAr ymUş/EKFIIL_RIVAYET_(y)mUş"
            )]
        public void GecmisMisRivayetOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmiş miymişim",
            "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("gelmiş miymişsin",
            "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gelmiş miymiş", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş")]
        [TestCase("gelmiş miymişiz",
            "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("gelmiş miymişsiniz",
            "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("gelmişler miymiş",
            "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş")]
        public void GecmisMisRivayetSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmemiş miymişim",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş yUm/EKFIIL_SAHIS_BEN_(y)Um"
            )]
        [TestCase("gelmemiş miymişsin",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş sUn/EKFIIL_SAHIS_SEN_sUn"
            )]
        [TestCase("gelmemiş miymiş",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş")]
        [TestCase("gelmemiş miymişiz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz"
            )]
        [TestCase("gelmemiş miymişsiniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz"
            )]
        [TestCase("gelmemişler miymiş",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş"
            )]
        public void GecmisMisRivayetSoruOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("geliyormuşum",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor ymUş/EKFIIL_RIVAYET_(y)mUş yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("geliyormuşsun",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor ymUş/EKFIIL_RIVAYET_(y)mUş sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("geliyormuş", "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor ymUş/EKFIIL_RIVAYET_(y)mUş")]
        [TestCase("geliyormuşuz",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor ymUş/EKFIIL_RIVAYET_(y)mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("geliyormuşsunuz",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor ymUş/EKFIIL_RIVAYET_(y)mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("geliyormuşlar",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor ymUş/EKFIIL_RIVAYET_(y)mUş lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("geliyorlarmış",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor lAr/EKFIIL_SAHIS_ONLAR_lAr ymUş/EKFIIL_RIVAYET_(y)mUş")]
        public void SimdikiRivayetOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmiyormuşum",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor ymUş/EKFIIL_RIVAYET_(y)mUş yUm/EKFIIL_SAHIS_BEN_(y)Um"
            )]
        [TestCase("gelmiyormuşsun",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor ymUş/EKFIIL_RIVAYET_(y)mUş sUn/EKFIIL_SAHIS_SEN_sUn"
            )]
        [TestCase("gelmiyormuş", "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor ymUş/EKFIIL_RIVAYET_(y)mUş")
        ]
        [TestCase("gelmiyormuşuz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor ymUş/EKFIIL_RIVAYET_(y)mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz"
            )]
        [TestCase("gelmiyormuşsunuz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor ymUş/EKFIIL_RIVAYET_(y)mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz"
            )]
        [TestCase("gelmiyormuşlar",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor ymUş/EKFIIL_RIVAYET_(y)mUş lAr/EKFIIL_SAHIS_ONLAR_lAr"
            )]
        [TestCase("gelmiyorlarmış",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor lAr/EKFIIL_SAHIS_ONLAR_lAr ymUş/EKFIIL_RIVAYET_(y)mUş"
            )]
        public void SimdikiRivayetOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("geliyor muymuşum",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("geliyor muymuşsun",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("geliyor muymuş", "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş")]
        [TestCase("geliyor muymuşuz",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("geliyor muymuşsunuz",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")
        ]
        [TestCase("geliyor muymuşlar",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("geliyorlar mıymış",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş")]
        public void SimdikiRivayetSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmiyor muymuşum",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş yUm/EKFIIL_SAHIS_BEN_(y)Um"
            )]
        [TestCase("gelmiyor muymuşsun",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş sUn/EKFIIL_SAHIS_SEN_sUn"
            )]
        [TestCase("gelmiyor muymuş",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş")]
        [TestCase("gelmiyor muymuşuz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz"
            )]
        [TestCase("gelmiyor muymuşsunuz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz"
            )]
        [TestCase("gelmiyor muymuşlar",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş lAr/EKFIIL_SAHIS_ONLAR_lAr"
            )]
        [TestCase("gelmiyorlar mıymış",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş"
            )]
        public void SimdikiRivayetSoruOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelecekmişim",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ymUş/EKFIIL_RIVAYET_(y)mUş yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("gelecekmişsin",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ymUş/EKFIIL_RIVAYET_(y)mUş sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gelecekmiş", "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ymUş/EKFIIL_RIVAYET_(y)mUş")]
        [TestCase("gelecekmişiz",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ymUş/EKFIIL_RIVAYET_(y)mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("gelecekmişsiniz",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ymUş/EKFIIL_RIVAYET_(y)mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("gelecekmişler",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ymUş/EKFIIL_RIVAYET_(y)mUş lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("geleceklermiş",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK lAr/EKFIIL_SAHIS_ONLAR_lAr ymUş/EKFIIL_RIVAYET_(y)mUş")]
        public void GelecekRivayetOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmeyecekmişim",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ymUş/EKFIIL_RIVAYET_(y)mUş yUm/EKFIIL_SAHIS_BEN_(y)Um"
            )]
        [TestCase("gelmeyecekmişsin",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ymUş/EKFIIL_RIVAYET_(y)mUş sUn/EKFIIL_SAHIS_SEN_sUn"
            )]
        [TestCase("gelmeyecekmiş",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ymUş/EKFIIL_RIVAYET_(y)mUş")]
        [TestCase("gelmeyecekmişiz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ymUş/EKFIIL_RIVAYET_(y)mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz"
            )]
        [TestCase("gelmeyecekmişsiniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ymUş/EKFIIL_RIVAYET_(y)mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz"
            )]
        [TestCase("gelmeyecekmişler",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ymUş/EKFIIL_RIVAYET_(y)mUş lAr/EKFIIL_SAHIS_ONLAR_lAr"
            )]
        [TestCase("gelmeyeceklermiş",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK lAr/EKFIIL_SAHIS_ONLAR_lAr ymUş/EKFIIL_RIVAYET_(y)mUş"
            )]
        public void GelecekRivayetOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelecek miymişim",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş yUm/EKFIIL_SAHIS_BEN_(y)Um")
        ]
        [TestCase("gelecek miymişsin",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gelecek miymiş", "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş")]
        [TestCase("gelecek miymişiz",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz")
        ]
        [TestCase("gelecek miymişsiniz",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz"
            )]
        [TestCase("gelecek miymişler",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş lAr/EKFIIL_SAHIS_ONLAR_lAr")
        ]
        [TestCase("gelecekler miymiş",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş")
        ]
        public void GelecekRivayetSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmeyecek miymişim",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş yUm/EKFIIL_SAHIS_BEN_(y)Um"
            )]
        [TestCase("gelmeyecek miymişsin",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş sUn/EKFIIL_SAHIS_SEN_sUn"
            )]
        [TestCase("gelmeyecek miymiş",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş")]
        [TestCase("gelmeyecek miymişiz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz"
            )]
        [TestCase("gelmeyecek miymişsiniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz"
            )]
        [TestCase("gelmeyecek miymişler",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş lAr/EKFIIL_SAHIS_ONLAR_lAr"
            )]
        [TestCase("gelmeyecekler miymiş",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş"
            )]
        public void GelecekRivayetSoruOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelirmişim", "gel/FIIL Ur/FC_ZAMAN_GENIS_(U)r ymUş/EKFIIL_RIVAYET_(y)mUş yUm/EKFIIL_SAHIS_BEN_(y)Um")
        ]
        [TestCase("gelirmişsin", "gel/FIIL Ur/FC_ZAMAN_GENIS_(U)r ymUş/EKFIIL_RIVAYET_(y)mUş sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gelirmiş", "gel/FIIL Ur/FC_ZAMAN_GENIS_(U)r ymUş/EKFIIL_RIVAYET_(y)mUş")]
        [TestCase("gelirmişiz", "gel/FIIL Ur/FC_ZAMAN_GENIS_(U)r ymUş/EKFIIL_RIVAYET_(y)mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz")
        ]
        [TestCase("gelirmişsiniz",
            "gel/FIIL Ur/FC_ZAMAN_GENIS_(U)r ymUş/EKFIIL_RIVAYET_(y)mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("gelirmişler", "gel/FIIL Ur/FC_ZAMAN_GENIS_(U)r ymUş/EKFIIL_RIVAYET_(y)mUş lAr/EKFIIL_SAHIS_ONLAR_lAr"
            )]
        [TestCase("gelirlermiş", "gel/FIIL Ur/FC_ZAMAN_GENIS_(U)r lAr/EKFIIL_SAHIS_ONLAR_lAr ymUş/EKFIIL_RIVAYET_(y)mUş"
            )]
        public void GenisRivayetOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmezmişim",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r ymUş/EKFIIL_RIVAYET_(y)mUş yUm/EKFIIL_SAHIS_BEN_(y)Um")
        ]
        [TestCase("gelmezmişsin",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r ymUş/EKFIIL_RIVAYET_(y)mUş sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gelmezmiş", "gel/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r ymUş/EKFIIL_RIVAYET_(y)mUş")]
        [TestCase("gelmezmişiz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r ymUş/EKFIIL_RIVAYET_(y)mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz")
        ]
        [TestCase("gelmezmişsiniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r ymUş/EKFIIL_RIVAYET_(y)mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz"
            )]
        [TestCase("gelmezmişler",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r ymUş/EKFIIL_RIVAYET_(y)mUş lAr/EKFIIL_SAHIS_ONLAR_lAr")
        ]
        [TestCase("gelmezlermiş",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r lAr/EKFIIL_SAHIS_ONLAR_lAr ymUş/EKFIIL_RIVAYET_(y)mUş")
        ]
        public void GenisRivayetOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelir miymişim",
            "gel/FIIL Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("gelir miymişsin",
            "gel/FIIL Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gelir miymiş", "gel/FIIL Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş")]
        [TestCase("gelir miymişiz",
            "gel/FIIL Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("gelir miymişsiniz",
            "gel/FIIL Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("gelir miymişler",
            "gel/FIIL Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("gelirler miymiş",
            "gel/FIIL Ur/FC_ZAMAN_GENIS_(U)r lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş")]
        public void GenisRivayetSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmez miymişim",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş yUm/EKFIIL_SAHIS_BEN_(y)Um"
            )]
        [TestCase("gelmez miymişsin",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş sUn/EKFIIL_SAHIS_SEN_sUn"
            )]
        [TestCase("gelmez miymiş",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş")]
        [TestCase("gelmez miymişiz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz"
            )]
        [TestCase("gelmez miymişsiniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz"
            )]
        [TestCase("gelmez miymişler",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş lAr/EKFIIL_SAHIS_ONLAR_lAr"
            )]
        [TestCase("gelmezler miymiş",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş"
            )]
        public void GenisRivayetSoruOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmeliymişim",
            "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI ymUş/EKFIIL_RIVAYET_(y)mUş yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("gelmeliymişsin",
            "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI ymUş/EKFIIL_RIVAYET_(y)mUş sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gelmeliymiş", "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI ymUş/EKFIIL_RIVAYET_(y)mUş")]
        [TestCase("gelmeliymişiz",
            "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI ymUş/EKFIIL_RIVAYET_(y)mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("gelmeliymişsiniz",
            "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI ymUş/EKFIIL_RIVAYET_(y)mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("gelmeliymişler",
            "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI ymUş/EKFIIL_RIVAYET_(y)mUş lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("gelmelilermiş",
            "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI lAr/EKFIIL_SAHIS_ONLAR_lAr ymUş/EKFIIL_RIVAYET_(y)mUş")]
        public void GereklilikRivayetOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmemeliymişim",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI ymUş/EKFIIL_RIVAYET_(y)mUş yUm/EKFIIL_SAHIS_BEN_(y)Um"
            )]
        [TestCase("gelmemeliymişsin",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI ymUş/EKFIIL_RIVAYET_(y)mUş sUn/EKFIIL_SAHIS_SEN_sUn"
            )]
        [TestCase("gelmemeliymiş", "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI ymUş/EKFIIL_RIVAYET_(y)mUş"
            )]
        [TestCase("gelmemeliymişiz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI ymUş/EKFIIL_RIVAYET_(y)mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz"
            )]
        [TestCase("gelmemeliymişsiniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI ymUş/EKFIIL_RIVAYET_(y)mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz"
            )]
        [TestCase("gelmemeliymişler",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI ymUş/EKFIIL_RIVAYET_(y)mUş lAr/EKFIIL_SAHIS_ONLAR_lAr"
            )]
        [TestCase("gelmemelilermiş",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI lAr/EKFIIL_SAHIS_ONLAR_lAr ymUş/EKFIIL_RIVAYET_(y)mUş"
            )]
        public void GereklilikRivayetOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmeli miymişim",
            "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("gelmeli miymişsin",
            "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gelmeli miymiş", "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş")]
        [TestCase("gelmeli miymişiz",
            "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("gelmeli miymişsiniz",
            "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("gelmeli miymişler",
            "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("gelmeliler miymiş",
            "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş")]
        public void GereklilikRivayetSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmemeli miymişim",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş yUm/EKFIIL_SAHIS_BEN_(y)Um"
            )]
        [TestCase("gelmemeli miymişsin",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş sUn/EKFIIL_SAHIS_SEN_sUn"
            )]
        [TestCase("gelmemeli miymiş",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş")]
        [TestCase("gelmemeli miymişiz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz"
            )]
        [TestCase("gelmemeli miymişsiniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz"
            )]
        [TestCase("gelmemeli miymişler",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş lAr/EKFIIL_SAHIS_ONLAR_lAr"
            )]
        [TestCase("gelmemeliler miymiş",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş"
            )]
        public void GereklilikRivayetSoruOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelseymişim", "gel/FIIL sA/FC_KIP_DILEK_sA ymUş/EKFIIL_RIVAYET_(y)mUş yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("gelseymişsin", "gel/FIIL sA/FC_KIP_DILEK_sA ymUş/EKFIIL_RIVAYET_(y)mUş sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gelseymiş", "gel/FIIL sA/FC_KIP_DILEK_sA ymUş/EKFIIL_RIVAYET_(y)mUş")]
        [TestCase("gelseymişiz", "gel/FIIL sA/FC_KIP_DILEK_sA ymUş/EKFIIL_RIVAYET_(y)mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("gelseymişsiniz",
            "gel/FIIL sA/FC_KIP_DILEK_sA ymUş/EKFIIL_RIVAYET_(y)mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("gelseymişler", "gel/FIIL sA/FC_KIP_DILEK_sA ymUş/EKFIIL_RIVAYET_(y)mUş lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("gelselermiş", "gel/FIIL sA/FC_KIP_DILEK_sA lAr/EKFIIL_SAHIS_ONLAR_lAr ymUş/EKFIIL_RIVAYET_(y)mUş")]
        public void DilekRivayetOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmeseymişim",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA ymUş/EKFIIL_RIVAYET_(y)mUş yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("gelmeseymişsin",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA ymUş/EKFIIL_RIVAYET_(y)mUş sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gelmeseymiş", "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA ymUş/EKFIIL_RIVAYET_(y)mUş")]
        [TestCase("gelmeseymişiz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA ymUş/EKFIIL_RIVAYET_(y)mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("gelmeseymişsiniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA ymUş/EKFIIL_RIVAYET_(y)mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("gelmeseymişler",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA ymUş/EKFIIL_RIVAYET_(y)mUş lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("gelmeselermiş",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA lAr/EKFIIL_SAHIS_ONLAR_lAr ymUş/EKFIIL_RIVAYET_(y)mUş")]
        public void DilekRivayetOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelse miymişim",
            "gel/FIIL sA/FC_KIP_DILEK_sA _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("gelse miymişsin",
            "gel/FIIL sA/FC_KIP_DILEK_sA _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gelse miymiş", "gel/FIIL sA/FC_KIP_DILEK_sA _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş")]
        [TestCase("gelse miymişiz",
            "gel/FIIL sA/FC_KIP_DILEK_sA _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("gelse miymişsiniz",
            "gel/FIIL sA/FC_KIP_DILEK_sA _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("gelse miymişler",
            "gel/FIIL sA/FC_KIP_DILEK_sA _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("gelseler miymiş",
            "gel/FIIL sA/FC_KIP_DILEK_sA lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş")]
        public void DilekRivayetSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmese miymişim",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş yUm/EKFIIL_SAHIS_BEN_(y)Um"
            )]
        [TestCase("gelmese miymişsin",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş sUn/EKFIIL_SAHIS_SEN_sUn"
            )]
        [TestCase("gelmese miymiş",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş")]
        [TestCase("gelmese miymişiz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz"
            )]
        [TestCase("gelmese miymişsiniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz"
            )]
        [TestCase("gelmese miymişler",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş lAr/EKFIIL_SAHIS_ONLAR_lAr"
            )]
        [TestCase("gelmeseler miymiş",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA sA/FC_KIP_DILEK_sA lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş"
            )]
        public void DilekRivayetSoruOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("geleymişim", "gel/FIIL yA/FC_KIP_ISTEK_(y)A ymUş/EKFIIL_RIVAYET_(y)mUş yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("geleymişsin", "gel/FIIL yA/FC_KIP_ISTEK_(y)A ymUş/EKFIIL_RIVAYET_(y)mUş sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("geleymiş", "gel/FIIL yA/FC_KIP_ISTEK_(y)A ymUş/EKFIIL_RIVAYET_(y)mUş")]
        [TestCase("geleymişiz", "gel/FIIL yA/FC_KIP_ISTEK_(y)A ymUş/EKFIIL_RIVAYET_(y)mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("geleymişsiniz",
            "gel/FIIL yA/FC_KIP_ISTEK_(y)A ymUş/EKFIIL_RIVAYET_(y)mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("geleymişler", "gel/FIIL yA/FC_KIP_ISTEK_(y)A ymUş/EKFIIL_RIVAYET_(y)mUş lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        public void IstekRivayetOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmeyeymişim",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A ymUş/EKFIIL_RIVAYET_(y)mUş yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("gelmeyeymişsin",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A ymUş/EKFIIL_RIVAYET_(y)mUş sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gelmeyeymiş", "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A ymUş/EKFIIL_RIVAYET_(y)mUş")]
        [TestCase("gelmeyeymişiz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A ymUş/EKFIIL_RIVAYET_(y)mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("gelmeyeymişsiniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A ymUş/EKFIIL_RIVAYET_(y)mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")
        ]
        [TestCase("gelmeyeymişler",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A ymUş/EKFIIL_RIVAYET_(y)mUş lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        public void IstekRivayetOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gele miymişim",
            "gel/FIIL yA/FC_KIP_ISTEK_(y)A _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş yUm/EKFIIL_SAHIS_BEN_(y)Um")]
        [TestCase("gele miymişsin",
            "gel/FIIL yA/FC_KIP_ISTEK_(y)A _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş sUn/EKFIIL_SAHIS_SEN_sUn")]
        [TestCase("gele miymiş", "gel/FIIL yA/FC_KIP_ISTEK_(y)A _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş")]
        [TestCase("gele miymişiz",
            "gel/FIIL yA/FC_KIP_ISTEK_(y)A _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz")]
        [TestCase("gele miymişsiniz",
            "gel/FIIL yA/FC_KIP_ISTEK_(y)A _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz")]
        [TestCase("gele miymişler",
            "gel/FIIL yA/FC_KIP_ISTEK_(y)A _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        public void IstekRivayetSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmeye miymişim",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş yUm/EKFIIL_SAHIS_BEN_(y)Um"
            )]
        [TestCase("gelmeye miymişsin",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş sUn/EKFIIL_SAHIS_SEN_sUn"
            )]
        [TestCase("gelmeye miymiş",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş")]
        [TestCase("gelmeye miymişiz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş yUz/EKFIIL_SAHIS_BIZ_(y)Uz"
            )]
        [TestCase("gelmeye miymişsiniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş sUnUz/EKFIIL_SAHIS_SIZ_sUnUz"
            )]
        [TestCase("gelmeye miymişler",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yA/FC_KIP_ISTEK_(y)A _mU/SORU_mU ymUş/EKFIIL_RIVAYET_(y)mUş lAr/EKFIIL_SAHIS_ONLAR_lAr"
            )]
        public void IstekRivayetSoruOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("geldiysem", "gel/FIIL DU/FC_ZAMAN_GECMIS_DU ysA/EKFIIL_SART_(y)sA m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("geldiysen", "gel/FIIL DU/FC_ZAMAN_GECMIS_DU ysA/EKFIIL_SART_(y)sA n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("geldiyse", "gel/FIIL DU/FC_ZAMAN_GECMIS_DU ysA/EKFIIL_SART_(y)sA")]
        [TestCase("geldiysek", "gel/FIIL DU/FC_ZAMAN_GECMIS_DU ysA/EKFIIL_SART_(y)sA k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("geldiyseniz", "gel/FIIL DU/FC_ZAMAN_GECMIS_DU ysA/EKFIIL_SART_(y)sA nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("geldiyseler", "gel/FIIL DU/FC_ZAMAN_GECMIS_DU ysA/EKFIIL_SART_(y)sA lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("geldilerse", "gel/FIIL DU/FC_ZAMAN_GECMIS_DU lAr/EKFIIL_SAHIS_ONLAR_lAr ysA/EKFIIL_SART_(y)sA")]
        public void GecmisDiSartOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmediysem",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU ysA/EKFIIL_SART_(y)sA m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gelmediysen",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU ysA/EKFIIL_SART_(y)sA n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gelmediyse", "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU ysA/EKFIIL_SART_(y)sA")]
        [TestCase("gelmediysek",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU ysA/EKFIIL_SART_(y)sA k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelmediyseniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU ysA/EKFIIL_SART_(y)sA nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("gelmediyseler",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU ysA/EKFIIL_SART_(y)sA lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("gelmedilerse",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU lAr/EKFIIL_SAHIS_ONLAR_lAr ysA/EKFIIL_SART_(y)sA")]
        public void GecmisDiSartOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("geldiysem mi",
            "gel/FIIL DU/FC_ZAMAN_GECMIS_DU ysA/EKFIIL_SART_(y)sA m/EKFIIL_SAHIS_BEN_m _mU/SORU_mU")]
        [TestCase("geldiysen mi",
            "gel/FIIL DU/FC_ZAMAN_GECMIS_DU ysA/EKFIIL_SART_(y)sA n/EKFIIL_SAHIS_SEN_n _mU/SORU_mU")]
        [TestCase("geldiyse mi", "gel/FIIL DU/FC_ZAMAN_GECMIS_DU ysA/EKFIIL_SART_(y)sA _mU/SORU_mU")]
        [TestCase("geldiysek mi",
            "gel/FIIL DU/FC_ZAMAN_GECMIS_DU ysA/EKFIIL_SART_(y)sA k/EKFIIL_SAHIS_BIZ_k _mU/SORU_mU")]
        [TestCase("geldiyseniz mi",
            "gel/FIIL DU/FC_ZAMAN_GECMIS_DU ysA/EKFIIL_SART_(y)sA nUz/EKFIIL_SAHIS_SIZ_nUz _mU/SORU_mU")]
        [TestCase("geldiyseler mi",
            "gel/FIIL DU/FC_ZAMAN_GECMIS_DU ysA/EKFIIL_SART_(y)sA lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU")]
        [TestCase("geldilerse mi",
            "gel/FIIL DU/FC_ZAMAN_GECMIS_DU lAr/EKFIIL_SAHIS_ONLAR_lAr ysA/EKFIIL_SART_(y)sA _mU/SORU_mU")]
        public void GecmisDiSartSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmediysem mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU ysA/EKFIIL_SART_(y)sA m/EKFIIL_SAHIS_BEN_m _mU/SORU_mU")
        ]
        [TestCase("gelmediysen mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU ysA/EKFIIL_SART_(y)sA n/EKFIIL_SAHIS_SEN_n _mU/SORU_mU")
        ]
        [TestCase("gelmediyse mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU ysA/EKFIIL_SART_(y)sA _mU/SORU_mU")]
        [TestCase("gelmediysek mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU ysA/EKFIIL_SART_(y)sA k/EKFIIL_SAHIS_BIZ_k _mU/SORU_mU")
        ]
        [TestCase("gelmediyseniz mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU ysA/EKFIIL_SART_(y)sA nUz/EKFIIL_SAHIS_SIZ_nUz _mU/SORU_mU"
            )]
        [TestCase("gelmediyseler mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU ysA/EKFIIL_SART_(y)sA lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU"
            )]
        [TestCase("gelmedilerse mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA DU/FC_ZAMAN_GECMIS_DU lAr/EKFIIL_SAHIS_ONLAR_lAr ysA/EKFIIL_SART_(y)sA _mU/SORU_mU"
            )]
        public void GecmisDiSartSoruOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmişsem", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş ysA/EKFIIL_SART_(y)sA m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gelmişsen", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş ysA/EKFIIL_SART_(y)sA n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gelmişse", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş ysA/EKFIIL_SART_(y)sA")]
        [TestCase("gelmişsek", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş ysA/EKFIIL_SART_(y)sA k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelmişseniz", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş ysA/EKFIIL_SART_(y)sA nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("gelmişseler", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş ysA/EKFIIL_SART_(y)sA lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("gelmişlerse", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş lAr/EKFIIL_SAHIS_ONLAR_lAr ysA/EKFIIL_SART_(y)sA")]
        public void GecmisMisSartOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmemişsem",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş ysA/EKFIIL_SART_(y)sA m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gelmemişsen",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş ysA/EKFIIL_SART_(y)sA n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gelmemişse", "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş ysA/EKFIIL_SART_(y)sA")]
        [TestCase("gelmemişsek",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş ysA/EKFIIL_SART_(y)sA k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelmemişseniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş ysA/EKFIIL_SART_(y)sA nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("gelmemişseler",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş ysA/EKFIIL_SART_(y)sA lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("gelmemişlerse",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş lAr/EKFIIL_SAHIS_ONLAR_lAr ysA/EKFIIL_SART_(y)sA")]
        public void GecmisMisSartOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmişsem mi",
            "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş ysA/EKFIIL_SART_(y)sA m/EKFIIL_SAHIS_BEN_m _mU/SORU_mU")]
        [TestCase("gelmişsen mi",
            "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş ysA/EKFIIL_SART_(y)sA n/EKFIIL_SAHIS_SEN_n _mU/SORU_mU")]
        [TestCase("gelmişse mi", "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş ysA/EKFIIL_SART_(y)sA _mU/SORU_mU")]
        [TestCase("gelmişsek mi",
            "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş ysA/EKFIIL_SART_(y)sA k/EKFIIL_SAHIS_BIZ_k _mU/SORU_mU")]
        [TestCase("gelmişseniz mi",
            "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş ysA/EKFIIL_SART_(y)sA nUz/EKFIIL_SAHIS_SIZ_nUz _mU/SORU_mU")]
        [TestCase("gelmişseler mi",
            "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş ysA/EKFIIL_SART_(y)sA lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU")]
        [TestCase("gelmişlerse mi",
            "gel/FIIL mUş/FC_ZAMAN_GECMIS_mUş lAr/EKFIIL_SAHIS_ONLAR_lAr ysA/EKFIIL_SART_(y)sA _mU/SORU_mU")]
        public void GecmisMisSartSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmemişsem mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş ysA/EKFIIL_SART_(y)sA m/EKFIIL_SAHIS_BEN_m _mU/SORU_mU"
            )]
        [TestCase("gelmemişsen mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş ysA/EKFIIL_SART_(y)sA n/EKFIIL_SAHIS_SEN_n _mU/SORU_mU"
            )]
        [TestCase("gelmemişse mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş ysA/EKFIIL_SART_(y)sA _mU/SORU_mU")]
        [TestCase("gelmemişsek mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş ysA/EKFIIL_SART_(y)sA k/EKFIIL_SAHIS_BIZ_k _mU/SORU_mU"
            )]
        [TestCase("gelmemişseniz mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş ysA/EKFIIL_SART_(y)sA nUz/EKFIIL_SAHIS_SIZ_nUz _mU/SORU_mU"
            )]
        [TestCase("gelmemişseler mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş ysA/EKFIIL_SART_(y)sA lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU"
            )]
        [TestCase("gelmemişlerse mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mUş/FC_ZAMAN_GECMIS_mUş lAr/EKFIIL_SAHIS_ONLAR_lAr ysA/EKFIIL_SART_(y)sA _mU/SORU_mU"
            )]
        public void GecmisMisSartSoruOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("geliyorsam", "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor ysA/EKFIIL_SART_(y)sA m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("geliyorsan", "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor ysA/EKFIIL_SART_(y)sA n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("geliyorsa", "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor ysA/EKFIIL_SART_(y)sA")]
        [TestCase("geliyorsak", "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor ysA/EKFIIL_SART_(y)sA k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("geliyorsanız", "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor ysA/EKFIIL_SART_(y)sA nUz/EKFIIL_SAHIS_SIZ_nUz"
            )]
        [TestCase("geliyorsalar",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor ysA/EKFIIL_SART_(y)sA lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("geliyorlarsa",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor lAr/EKFIIL_SAHIS_ONLAR_lAr ysA/EKFIIL_SART_(y)sA")]
        public void SimdikiSartOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmiyorsam",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor ysA/EKFIIL_SART_(y)sA m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gelmiyorsan",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor ysA/EKFIIL_SART_(y)sA n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gelmiyorsa", "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor ysA/EKFIIL_SART_(y)sA")]
        [TestCase("gelmiyorsak",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor ysA/EKFIIL_SART_(y)sA k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelmiyorsanız",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor ysA/EKFIIL_SART_(y)sA nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("gelmiyorsalar",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor ysA/EKFIIL_SART_(y)sA lAr/EKFIIL_SAHIS_ONLAR_lAr"
            )]
        [TestCase("gelmiyorlarsa",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor lAr/EKFIIL_SAHIS_ONLAR_lAr ysA/EKFIIL_SART_(y)sA"
            )]
        public void SimdikiSartOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("geliyorsam mı",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor ysA/EKFIIL_SART_(y)sA m/EKFIIL_SAHIS_BEN_m _mU/SORU_mU")]
        [TestCase("geliyorsan mı",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor ysA/EKFIIL_SART_(y)sA n/EKFIIL_SAHIS_SEN_n _mU/SORU_mU")]
        [TestCase("geliyorsa mı", "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor ysA/EKFIIL_SART_(y)sA _mU/SORU_mU")]
        [TestCase("geliyorsak mı",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor ysA/EKFIIL_SART_(y)sA k/EKFIIL_SAHIS_BIZ_k _mU/SORU_mU")]
        [TestCase("geliyorsanız mı",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor ysA/EKFIIL_SART_(y)sA nUz/EKFIIL_SAHIS_SIZ_nUz _mU/SORU_mU")]
        [TestCase("geliyorsalar mı",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor ysA/EKFIIL_SART_(y)sA lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU")]
        [TestCase("geliyorlarsa mı",
            "gel/FIIL Uyor/FC_ZAMAN_SIMDIKI_(U)yor lAr/EKFIIL_SAHIS_ONLAR_lAr ysA/EKFIIL_SART_(y)sA _mU/SORU_mU")]
        public void SimdikiSartSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmiyorsam mı",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor ysA/EKFIIL_SART_(y)sA m/EKFIIL_SAHIS_BEN_m _mU/SORU_mU"
            )]
        [TestCase("gelmiyorsan mı",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor ysA/EKFIIL_SART_(y)sA n/EKFIIL_SAHIS_SEN_n _mU/SORU_mU"
            )]
        [TestCase("gelmiyorsa mı",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor ysA/EKFIIL_SART_(y)sA _mU/SORU_mU")]
        [TestCase("gelmiyorsak mı",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor ysA/EKFIIL_SART_(y)sA k/EKFIIL_SAHIS_BIZ_k _mU/SORU_mU"
            )]
        [TestCase("gelmiyorsanız mı",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor ysA/EKFIIL_SART_(y)sA nUz/EKFIIL_SAHIS_SIZ_nUz _mU/SORU_mU"
            )]
        [TestCase("gelmiyorsalar mı",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor ysA/EKFIIL_SART_(y)sA lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU"
            )]
        [TestCase("gelmiyorlarsa mı",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Uyor/FC_ZAMAN_SIMDIKI_(U)yor lAr/EKFIIL_SAHIS_ONLAR_lAr ysA/EKFIIL_SART_(y)sA _mU/SORU_mU"
            )]
        public void SimdikiSartSoruOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("geleceksem", "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ysA/EKFIIL_SART_(y)sA m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("geleceksen", "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ysA/EKFIIL_SART_(y)sA n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gelecekse", "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ysA/EKFIIL_SART_(y)sA")]
        [TestCase("gelecekseniz",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ysA/EKFIIL_SART_(y)sA nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("geleceksek", "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ysA/EKFIIL_SART_(y)sA k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelecekseler",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ysA/EKFIIL_SART_(y)sA lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("geleceklerse",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK lAr/EKFIIL_SAHIS_ONLAR_lAr ysA/EKFIIL_SART_(y)sA")]
        public void GelecekSartOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmeyeceksem",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ysA/EKFIIL_SART_(y)sA m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gelmeyeceksen",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ysA/EKFIIL_SART_(y)sA n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gelmeyecekse", "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ysA/EKFIIL_SART_(y)sA")]
        [TestCase("gelmeyecekseniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ysA/EKFIIL_SART_(y)sA nUz/EKFIIL_SAHIS_SIZ_nUz"
            )]
        [TestCase("gelmeyeceksek",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ysA/EKFIIL_SART_(y)sA k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelmeyecekseler",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ysA/EKFIIL_SART_(y)sA lAr/EKFIIL_SAHIS_ONLAR_lAr"
            )]
        [TestCase("gelmeyeceklerse",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK lAr/EKFIIL_SAHIS_ONLAR_lAr ysA/EKFIIL_SART_(y)sA"
            )]
        public void GelecekSartOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("geleceksem mi",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ysA/EKFIIL_SART_(y)sA m/EKFIIL_SAHIS_BEN_m _mU/SORU_mU")]
        [TestCase("geleceksen mi",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ysA/EKFIIL_SART_(y)sA n/EKFIIL_SAHIS_SEN_n _mU/SORU_mU")]
        [TestCase("gelecekse mi", "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ysA/EKFIIL_SART_(y)sA _mU/SORU_mU")]
        [TestCase("gelecekseniz mi",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ysA/EKFIIL_SART_(y)sA nUz/EKFIIL_SAHIS_SIZ_nUz _mU/SORU_mU")]
        [TestCase("geleceksek mi",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ysA/EKFIIL_SART_(y)sA k/EKFIIL_SAHIS_BIZ_k _mU/SORU_mU")]
        [TestCase("gelecekseler mi",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ysA/EKFIIL_SART_(y)sA lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU")]
        [TestCase("geleceklerse mi",
            "gel/FIIL yAcAk/FC_ZAMAN_GELECEK_(y)AcAK lAr/EKFIIL_SAHIS_ONLAR_lAr ysA/EKFIIL_SART_(y)sA _mU/SORU_mU")]
        public void GelecekSartSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmeyeceksem mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ysA/EKFIIL_SART_(y)sA m/EKFIIL_SAHIS_BEN_m _mU/SORU_mU"
            )]
        [TestCase("gelmeyeceksen mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ysA/EKFIIL_SART_(y)sA n/EKFIIL_SAHIS_SEN_n _mU/SORU_mU"
            )]
        [TestCase("gelmeyecekse mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ysA/EKFIIL_SART_(y)sA _mU/SORU_mU")]
        [TestCase("gelmeyecekseniz mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ysA/EKFIIL_SART_(y)sA nUz/EKFIIL_SAHIS_SIZ_nUz _mU/SORU_mU"
            )]
        [TestCase("gelmeyeceksek mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ysA/EKFIIL_SART_(y)sA k/EKFIIL_SAHIS_BIZ_k _mU/SORU_mU"
            )]
        [TestCase("gelmeyecekseler mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK ysA/EKFIIL_SART_(y)sA lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU"
            )]
        [TestCase("gelmeyeceklerse mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA yAcAk/FC_ZAMAN_GELECEK_(y)AcAK lAr/EKFIIL_SAHIS_ONLAR_lAr ysA/EKFIIL_SART_(y)sA _mU/SORU_mU"
            )]
        public void GelecekSartSoruOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelirsem", "gel/FIIL Ur/FC_ZAMAN_GENIS_(U)r ysA/EKFIIL_SART_(y)sA m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gelirsen", "gel/FIIL Ur/FC_ZAMAN_GENIS_(U)r ysA/EKFIIL_SART_(y)sA n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gelirse", "gel/FIIL Ur/FC_ZAMAN_GENIS_(U)r ysA/EKFIIL_SART_(y)sA")]
        [TestCase("gelirsek", "gel/FIIL Ur/FC_ZAMAN_GENIS_(U)r ysA/EKFIIL_SART_(y)sA k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelirseniz", "gel/FIIL Ur/FC_ZAMAN_GENIS_(U)r ysA/EKFIIL_SART_(y)sA nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("gelirseler", "gel/FIIL Ur/FC_ZAMAN_GENIS_(U)r ysA/EKFIIL_SART_(y)sA lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("gelirlerse", "gel/FIIL Ur/FC_ZAMAN_GENIS_(U)r lAr/EKFIIL_SAHIS_ONLAR_lAr ysA/EKFIIL_SART_(y)sA")]
        public void GenisSartOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmezsem",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r ysA/EKFIIL_SART_(y)sA m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gelmezsen",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r ysA/EKFIIL_SART_(y)sA n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gelmezse", "gel/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r ysA/EKFIIL_SART_(y)sA")]
        [TestCase("gelmezsek",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r ysA/EKFIIL_SART_(y)sA k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelmezseniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r ysA/EKFIIL_SART_(y)sA nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("gelmezseler",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r ysA/EKFIIL_SART_(y)sA lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        [TestCase("gelmezlerse",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r lAr/EKFIIL_SAHIS_ONLAR_lAr ysA/EKFIIL_SART_(y)sA")]
        public void GenisSartOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelirsem mi",
            "gel/FIIL Ur/FC_ZAMAN_GENIS_(U)r ysA/EKFIIL_SART_(y)sA m/EKFIIL_SAHIS_BEN_m _mU/SORU_mU")]
        [TestCase("gelirsen mi",
            "gel/FIIL Ur/FC_ZAMAN_GENIS_(U)r ysA/EKFIIL_SART_(y)sA n/EKFIIL_SAHIS_SEN_n _mU/SORU_mU")]
        [TestCase("gelirse mi", "gel/FIIL Ur/FC_ZAMAN_GENIS_(U)r ysA/EKFIIL_SART_(y)sA _mU/SORU_mU")]
        [TestCase("gelirsek mi",
            "gel/FIIL Ur/FC_ZAMAN_GENIS_(U)r ysA/EKFIIL_SART_(y)sA k/EKFIIL_SAHIS_BIZ_k _mU/SORU_mU")]
        [TestCase("gelirseniz mi",
            "gel/FIIL Ur/FC_ZAMAN_GENIS_(U)r ysA/EKFIIL_SART_(y)sA nUz/EKFIIL_SAHIS_SIZ_nUz _mU/SORU_mU")]
        [TestCase("gelirseler mi",
            "gel/FIIL Ur/FC_ZAMAN_GENIS_(U)r ysA/EKFIIL_SART_(y)sA lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU")]
        [TestCase("gelirlerse mi",
            "gel/FIIL Ur/FC_ZAMAN_GENIS_(U)r lAr/EKFIIL_SAHIS_ONLAR_lAr ysA/EKFIIL_SART_(y)sA _mU/SORU_mU")]
        public void GenisSartSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmezsem mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r ysA/EKFIIL_SART_(y)sA m/EKFIIL_SAHIS_BEN_m _mU/SORU_mU"
            )]
        [TestCase("gelmezsen mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r ysA/EKFIIL_SART_(y)sA n/EKFIIL_SAHIS_SEN_n _mU/SORU_mU"
            )]
        [TestCase("gelmezse mi", "gel/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r ysA/EKFIIL_SART_(y)sA _mU/SORU_mU"
            )]
        [TestCase("gelmezsek mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r ysA/EKFIIL_SART_(y)sA k/EKFIIL_SAHIS_BIZ_k _mU/SORU_mU"
            )]
        [TestCase("gelmezseniz mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r ysA/EKFIIL_SART_(y)sA nUz/EKFIIL_SAHIS_SIZ_nUz _mU/SORU_mU"
            )]
        [TestCase("gelmezseler mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r ysA/EKFIIL_SART_(y)sA lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU"
            )]
        [TestCase("gelmezlerse mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA Ur/FC_ZAMAN_GENIS_(U)r lAr/EKFIIL_SAHIS_ONLAR_lAr ysA/EKFIIL_SART_(y)sA _mU/SORU_mU"
            )]
        public void GenisSartSoruOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmeliysem", "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI ysA/EKFIIL_SART_(y)sA m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gelmeliysen", "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI ysA/EKFIIL_SART_(y)sA n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gelmeliyse", "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI ysA/EKFIIL_SART_(y)sA")]
        [TestCase("gelmeliysek", "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI ysA/EKFIIL_SART_(y)sA k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelmeliyseniz", "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI ysA/EKFIIL_SART_(y)sA nUz/EKFIIL_SAHIS_SIZ_nUz"
            )]
        [TestCase("gelmeliyseler",
            "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI ysA/EKFIIL_SART_(y)sA lAr/EKFIIL_SAHIS_ONLAR_lAr")]
        public void GereklilikSartOlumluTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("gelmemeliysem",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI ysA/EKFIIL_SART_(y)sA m/EKFIIL_SAHIS_BEN_m")]
        [TestCase("gelmemeliysen",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI ysA/EKFIIL_SART_(y)sA n/EKFIIL_SAHIS_SEN_n")]
        [TestCase("gelmemeliyse", "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI ysA/EKFIIL_SART_(y)sA")]
        [TestCase("gelmemeliysek",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI ysA/EKFIIL_SART_(y)sA k/EKFIIL_SAHIS_BIZ_k")]
        [TestCase("gelmemeliyseniz",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI ysA/EKFIIL_SART_(y)sA nUz/EKFIIL_SAHIS_SIZ_nUz")]
        [TestCase("gelmemeliyseler",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI ysA/EKFIIL_SART_(y)sA lAr/EKFIIL_SAHIS_ONLAR_lAr")
        ]
        public void GereklilikSartOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmeliysem mi",
            "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI ysA/EKFIIL_SART_(y)sA m/EKFIIL_SAHIS_BEN_m _mU/SORU_mU")]
        [TestCase("gelmeliysen mi",
            "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI ysA/EKFIIL_SART_(y)sA n/EKFIIL_SAHIS_SEN_n _mU/SORU_mU")]
        [TestCase("gelmeliyse mi", "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI ysA/EKFIIL_SART_(y)sA _mU/SORU_mU")]
        [TestCase("gelmeliysek mi",
            "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI ysA/EKFIIL_SART_(y)sA k/EKFIIL_SAHIS_BIZ_k _mU/SORU_mU")]
        [TestCase("gelmeliyseniz mi",
            "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI ysA/EKFIIL_SART_(y)sA nUz/EKFIIL_SAHIS_SIZ_nUz _mU/SORU_mU")]
        [TestCase("gelmeliyseler mi",
            "gel/FIIL mAlI/FC_KIP_GEREKLILIK_mAlI ysA/EKFIIL_SART_(y)sA lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU")]
        public void GereklilikSartSoruTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        
        [TestCase("gelmemeliysem mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI ysA/EKFIIL_SART_(y)sA m/EKFIIL_SAHIS_BEN_m _mU/SORU_mU"
            )]
        [TestCase("gelmemeliysen mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI ysA/EKFIIL_SART_(y)sA n/EKFIIL_SAHIS_SEN_n _mU/SORU_mU"
            )]
        [TestCase("gelmemeliyse mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI ysA/EKFIIL_SART_(y)sA _mU/SORU_mU")]
        [TestCase("gelmemeliysek mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI ysA/EKFIIL_SART_(y)sA k/EKFIIL_SAHIS_BIZ_k _mU/SORU_mU"
            )]
        [TestCase("gelmemeliyseniz mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI ysA/EKFIIL_SART_(y)sA nUz/EKFIIL_SAHIS_SIZ_nUz _mU/SORU_mU"
            )]
        [TestCase("gelmemeliyseler mi",
            "gel/FIIL mA/FY_OLUMSUZLUK_mA mAlI/FC_KIP_GEREKLILIK_mAlI ysA/EKFIIL_SART_(y)sA lAr/EKFIIL_SAHIS_ONLAR_lAr _mU/SORU_mU"
            )]
        public void GereklilikSartSoruOlumsuzTest(string token, string analysis)
        {
            Tester.ContainsAnalysis(token, analysis);
        }

        [TestCase("geldiymişim")]
        [TestCase("geldiymişsin")]
        [TestCase("geldiymiş")]
        [TestCase("geldiymişiz")]
        [TestCase("geldiymişsiniz")]
        [TestCase("geldiymişler")]
        [TestCase("geldilermiş")]
        public void GecersizGecmisDiRivayetTest(string token)
        {
            Tester.HasNoAnalysis(token);
        }

        [TestCase("gelseysem")]
        [TestCase("gelseysen")]
        [TestCase("gelseyse")]
        [TestCase("gelseysek")]
        [TestCase("gelseyseniz")]
        [TestCase("gelseyseler")]
        [TestCase("gelselerse")]
        public void GecersizDilekSartTest(string token)
        {
            Tester.HasNoAnalysis(token);
        }

        [TestCase("geleysem")]
        [TestCase("geleysen")]
        [TestCase("geleyse")]
        [TestCase("geleysek")]
        [TestCase("geleyseniz")]
        [TestCase("geleyseler")]
        [TestCase("gelelerse")]
        public void GecersizIstekSartTest(string token)
        {
            Tester.HasNoAnalysis(token);
        }

        [TestCase("gelsindi")]
        [TestCase("gelinizdi")]
        [TestCase("gelsinlerdi")]
        [TestCase("gelsinmiş")]
        [TestCase("gelinizmiş")]
        [TestCase("gelsinlermiş")]
        [TestCase("gelsinse")]
        [TestCase("gelinizse")]
        [TestCase("gelsinlerse")]
        public void GecersizEmirHikayeRivayetSartTest(string token)
        {
            Tester.HasNoAnalysis(token);
        }

        [TestCase("geldi miyim")]
        [TestCase("geldi misin")]
        [TestCase("geldi miyiz")]
        [TestCase("geldi misiniz")]
        [TestCase("geldi miler")]
        public void GecersizZamanDiSoruTest(string token)
        {
            Tester.HasNoAnalysis(token);
        }

        [TestCase("gelmişsin mi")]
        [TestCase("gelmişiz mi")]
        [TestCase("gel miymiş")]
        [TestCase("gelmişsiniz mi")]
        [TestCase("gelmiş miler")]
        public void GecersizGecmisMisSoruTest(string token)
        {
            Tester.HasNoAnalysis(token);
        }

        [TestCase("geliyorum mu")]
        [TestCase("geliyorsun mu")]
        [TestCase("geliyoruz mu")]
        [TestCase("geliyorsunuz mu")]
        [TestCase("geliyor mular")]
        public void GecersizSimdikiSoruTest(string token)
        {
            Tester.HasNoAnalysis(token);
        }

        [TestCase("yaparım mı")]
        [TestCase("yaparsın mı")]
        [TestCase("yaparız mı")]
        [TestCase("yaparsınız mı")]
        [TestCase("yapar mılar")]
        public void GecersizGenisSoruTest(string token)
        {
            Tester.HasNoAnalysis(token);
        }

        [TestCase("gelmeliyim mi")]
        [TestCase("gelmelisin mi")]
        [TestCase("gelmeliyiz mi")]
        [TestCase("gelmelisiniz mi")]
        [TestCase("gelmeli miler")]
        public void GecersizGereklilikSoruTest(string token)
        {
            Tester.HasNoAnalysis(token);
        }

        [TestCase("gelse miyim")]
        [TestCase("gelse misin")]
        [TestCase("gelse miyiz")]
        [TestCase("gelse misiniz")]
        [TestCase("gelse miler")]
        public void GecersizDilekSoruTest(string token)
        {
            Tester.HasNoAnalysis(token);
        }

        [TestCase("gele miyim")]
        [TestCase("gele misin")]
        [TestCase("gele miyiz")]
        [TestCase("gele misiniz")]
        [TestCase("gele miler")]
        public void GecersizIstekSoruTest(string token)
        {
            Tester.HasNoAnalysis(token);
        }

        [TestCase("geldiydim mi")]
        [TestCase("geldiydin mi")]
        [TestCase("geldiydi mi")]
        [TestCase("geldiydik mi")]
        [TestCase("geldiydiniz mi")]
        [TestCase("geldiydiler mi")]
        public void GecersizGecmisDiHikayeSoruTest(string token)
        {
            Tester.HasNoAnalysis(token);
        }

        [TestCase("gelmiştim mi")]
        [TestCase("gelmiştin mi")]
        [TestCase("gelmişti mi")]
        [TestCase("gelmiştik mi")]
        [TestCase("gelmiştiniz mi")]
        [TestCase("gelmiştiler mi")]
        [TestCase("gelmişlerdi mi")]
        public void GecersizGecmisMisHikayeSoruTest(string token)
        {
            Tester.HasNoAnalysis(token);
        }

        [TestCase("geliyordum mu")]
        [TestCase("geliyordun mu")]
        [TestCase("geliyordu mu")]
        [TestCase("geliyorduk mu")]
        [TestCase("geliyordunuz mu")]
        [TestCase("geliyorlardı mı")]
        [TestCase("geliyordular mı")]
        public void GecersizSimdikiHikayeSoruTest(string token)
        {
            Tester.HasNoAnalysis(token);
        }

        [TestCase("gelecektim mi")]
        [TestCase("gelecektin mi")]
        [TestCase("gelecekti mi")]
        [TestCase("gelecektik mi")]
        [TestCase("gelecektiniz mi")]
        [TestCase("gelecektiler mi")]
        [TestCase("geleceklerdi mi")]
        public void GecersizGelecekHikayeSoruTest(string token)
        {
            Tester.HasNoAnalysis(token);
        }

        [TestCase("gezerdim mi")]
        [TestCase("gezerdin mi")]
        [TestCase("gezerdi mi")]
        [TestCase("gezerdik mi")]
        [TestCase("gezerdiniz mi")]
        [TestCase("gezerdiler mi")]
        [TestCase("gezerlerdi mi")]
        public void GecersizGenisHikayeSoruTest(string token)
        {
            Tester.HasNoAnalysis(token);
        }

        [TestCase("gelmeliydim mi")]
        [TestCase("gelmeliydin mi")]
        [TestCase("gelmeliydi mi")]
        [TestCase("gelmeliydik mi")]
        [TestCase("gelmeliydiniz mi")]
        [TestCase("gelmeliydiler mi")]
        public void GecersizGereklilikHikayeSoruTest(string token)
        {
            Tester.HasNoAnalysis(token);
        }

        [TestCase("gelseydim mi")]
        [TestCase("gelseydin mi")]
        [TestCase("gelseydi mi")]
        [TestCase("gelseydik mi")]
        [TestCase("gelseydiniz mi")]
        [TestCase("gelseydiler mi")]
        [TestCase("gelselerdi mi")]
        public void GecersizDilekHikayeSoruTest(string token)
        {
            Tester.HasNoAnalysis(token);
        }

        [TestCase("geleydim mi")]
        [TestCase("geleydin mi")]
        [TestCase("geleydi mi")]
        [TestCase("geleydik mi")]
        [TestCase("geleydiniz mi")]
        [TestCase("geleydiler mi")]
        public void GecersizIstekHikayeSoruTest(string token)
        {
            Tester.HasNoAnalysis(token);
        }

        [TestCase("geldi miysem")]
        [TestCase("geldi miysen")]
        [TestCase("geldi miyse")]
        [TestCase("geldi miysek")]
        [TestCase("geldi miyseniz")]
        [TestCase("geldi miyseler")]
        [TestCase("geldi milerse")]
        [TestCase("geldiyse miyim")]
        [TestCase("geldiyse misin")]
        [TestCase("geldiyse miyiz")]
        [TestCase("geldiyse misiniz")]
        [TestCase("geldiyse miler")]
        public void GecersizGecmisDiSartSoruTest(string token)
        {
            Tester.HasNoAnalysis(token);
        }

        [TestCase("gelmese milermiş")]
        [TestCase("geliyor mular")]
        [TestCase("geliyormuştu")]
        [TestCase("gelmiştiler mi")]
        [TestCase("gelmiyor muysalar")]
        [TestCase("gelelerdi")]
        public void GecersizCekimCesitliTest(string token)
        {
            Tester.HasNoAnalysis(token);
        }
    }
}