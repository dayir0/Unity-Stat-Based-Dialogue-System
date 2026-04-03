# 💬 Unity Stat Tabanlı Diyalog Sistemi

![Unity Version](https://img.shields.io/badge/Unity-2021.3%2B-black?style=flat-square&logo=unity)
![License](https://img.shields.io/badge/License-MIT-blue?style=flat-square)
![C#](https://img.shields.io/badge/Language-C%23-green?style=flat-square)

Unity için veri odaklı, RPG tarzı bir diyalog sistemi. *Fallout* ve *Baldur's Gate* gibi klasik RPG'lerden ilham alan bu sistem; oyuncunun mevcut özelliklerine (örn. Güç, Zeka, Karizma) bağlı olarak diyalog seçeneklerini dinamik olarak gösterir, gizler veya kilitler.

## ✨ Özellikler

* **Veri Odaklı (Data-Driven) İş Akışı:** Tek satır kod yazmadan `ScriptableObject` yapısını kullanarak karmaşık ve dallanan diyalog ağaçları oluşturun.
* **Stat Gereksinimleri:** Özelleştirilebilir oyuncu özelliklerine (stat) dayalı olarak belirli diyalog seçeneklerini kilitleyin veya açın.
* **Adaptör (Köprü) Desteği:** Sağlanan "Connector" kodunu kullanarak, sistemi *halihazırda var olan* karakter kontrolcünüze ve stat sisteminize kolayca entegre edin.
* **Görsel Geri Bildirim:** Oyuncu stat gereksinimlerini karşılamıyorsa diyalog butonlarını otomatik olarak karartır ve kilitler.
* **UI Uyumluluğu:** Unity'nin varsayılan UI sistemi ve TextMeshPro ile tam uyumludur.

## 📦 Başlangıç

Bu sistemi projenize entegre etmek için iki seçeneğiniz var:

### Seçenek 1: Örnek Projeyi İnceleyin (Önerilen)
Sistemin 3 boyutlu bir ortamda, bir Oyuncu ve bir NPC ile nasıl çalıştığını görmek istiyorsanız:
1. Bu depoyu (repository) **ZIP dosyası** olarak indirin.
2. Klasöre çıkartın ve **Unity Hub** üzerinden açın (`Add Project`).
3. `DemoScene` sahnesini açın ve Play'e basın. NPC'ye yaklaşın ve etkileşime geçmek için `E` tuşuna basın!

### Seçenek 2: .unitypackage ile Kurulum
Bu sistemi doğrudan kendi mevcut oyununuza aktarmak istiyorsanız:
1. [Releases](../../releases) (Sürümler) sayfasına gidin.
2. `StatBasedDialogueSystem.unitypackage` dosyasını indirin.
3. Paketi Unity projenizin içine sürükleyip bırakın ve tüm assetleri içeri aktarın (Import).

## 🛠️ Nasıl Kullanılır

### 1. Diyalog Düğümü (Node) Oluşturma
1. Project penceresinde sağ tıklayın.
2. `Create > Dialogue > New Node` yolunu izleyin.
3. NPC'nin metnini girin ve oyuncunun cevaplarını (`Options`) ekleyin.
4. (İsteğe bağlı) Bir seçenek için bir `Requirement` (Gereksinim) ayarlayın (Örn: `Strength` minimum `15`).

### 2. Diyaloğu Tetikleme
Kendi etkileşim kodlarınız üzerinden bir diyaloğu başlatmak için şu kodu çağırmanız yeterlidir:
```csharp
FindObjectOfType<DialogueManager>().StartDialogue(sizinDiyalogDosyaniz);
```

### 3. Kendi Karakter İstatistiklerinizi Kullanma
Varsayılan `PlayerStats.cs` kodunu kullanmak yerine, diyalog sistemi ile kendi mevcut oyuncu kontrolcünüz arasında köprü kurmak için `DialogueStatConnector.cs` scriptini kullanabilirsiniz. Tek yapmanız gereken, değişkenlerinizi `CheckRequirement` fonksiyonundaki Switch-Case yapısının içine eşleştirmektir.

## 🤝 Katkıda Bulunma
Geliştirme taleplerine (Pull Request) açığız! Büyük değişiklikler için, lütfen önce neyi değiştirmek istediğinizi tartışmak üzere bir konu (Issue) açın.

## 📜 Lisans
Bu proje MIT Lisansı altında lisanslanmıştır - detaylar için [LICENSE](LICENSE) dosyasına bakabilirsiniz.

---
> **🌐 For English Speakers:**
> You can find the English documentation in the root directory's `README.md` file.
