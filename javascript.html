<!DOCTYPE html>
<html lang="tr">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>JavaScript Döngüler Rehberi</title>
    <style>
        /* Temel Ayarlar ve Renk Paleti */
        :root {
            --primary-color: #3b82f6; /* Canlı bir mavi */
            --bg-color: #f1f5f9;
            --sidebar-bg: #ffffff;
            --text-dark: #1e293b;
            --text-light: #64748b;
            --code-bg: #1e1e1e;
        }

        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            margin: 0;
            display: flex;
            height: 100vh;
            background-color: var(--bg-color);
            color: var(--text-dark);
        }

        /* Yan Menü Tasarımı */
        aside {
            width: 250px;
            background-color: var(--sidebar-bg);
            box-shadow: 2px 0 5px rgba(0,0,0,0.05);
            padding: 20px 0;
            display: flex;
            flex-direction: column;
        }

        aside h2 {
            padding: 0 20px;
            font-size: 1.2rem;
            color: var(--primary-color);
            margin-bottom: 20px;
        }

        .menu-btn {
            background: none;
            border: none;
            padding: 15px 20px;
            text-align: left;
            font-size: 1rem;
            color: var(--text-dark);
            cursor: pointer;
            transition: all 0.3s ease;
            border-left: 4px solid transparent;
        }

        .menu-btn:hover {
            background-color: #f8fafc;
            color: var(--primary-color);
        }

        .menu-btn.active {
            background-color: #eff6ff;
            border-left-color: var(--primary-color);
            color: var(--primary-color);
            font-weight: bold;
        }

        /* Ana İçerik Alanı */
        main {
            flex: 1;
            padding: 40px;
            overflow-y: auto;
        }

        .content-card {
            background: #ffffff;
            padding: 30px;
            border-radius: 12px;
            box-shadow: 0 4px 6px rgba(0,0,0,0.05);
            max-width: 800px;
        }

        h1 {
            margin-top: 0;
            color: var(--text-dark);
        }

        p.description {
            color: var(--text-light);
            line-height: 1.6;
            margin-bottom: 25px;
            font-size: 1.1rem;
        }

        /* Kod ve Çıktı Kutuları */
        .box-title {
            font-size: 1rem;
            font-weight: bold;
            margin-bottom: 10px;
            display: inline-block;
            border-bottom: 2px solid var(--primary-color);
            padding-bottom: 3px;
        }

        pre {
            background-color: var(--code-bg);
            color: #d4d4d4;
            padding: 15px;
            border-radius: 8px;
            overflow-x: auto;
            font-family: 'Courier New', Courier, monospace;
            font-size: 0.95rem;
            margin-bottom: 25px;
        }

        .output-box {
            background-color: #f8fafc;
            border: 1px solid #e2e8f0;
            padding: 15px;
            border-radius: 8px;
            min-height: 80px;
            font-family: monospace;
            font-size: 1.1rem;
            color: #0f172a;
        }

        .output-item {
            margin: 5px 0;
            padding: 5px;
            background: #e0f2fe;
            border-radius: 4px;
            display: inline-block;
            margin-right: 10px;
        }
    </style>
</head>
<body>

    <aside>
        <h2>Döngü Tipleri</h2>
        <button class="menu-btn active" onclick="loadLoop('for')">for Döngüsü</button>
        <button class="menu-btn" onclick="loadLoop('while')">while Döngüsü</button>
        <button class="menu-btn" onclick="loadLoop('doWhile')">do...while Döngüsü</button>
        <button class="menu-btn" onclick="loadLoop('forIn')">for...in (Objeler)</button>
        <button class="menu-btn" onclick="loadLoop('forOf')">for...of (Diziler)</button>
    </aside>

    <main>
        <div class="content-card">
            <h1 id="title">Seçim Yapın</h1>
            <p id="description" class="description">Öğrenmek istediğiniz döngüyü sol menüden seçin.</p>
            
            <div class="box-title">Kod Yapısı:</div>
            <pre><code id="code-block">// Kod buraya gelecek</code></pre>
            
            <div class="box-title">Canlı Görsel Çıktı (Uygulama):</div>
            <div id="output-block" class="output-box">
                </div>
        </div>
    </main>

    <script>
        // Tüm döngülerin bilgilerini ve çalıştırılacak fonksiyonlarını içeren veri objesi
        const loopData = {
            "for": {
                title: "for Döngüsü",
                description: "En çok kullanılan döngüdür. Başlangıç değişkeni, çalışma koşulu ve artış/azalış miktarını tek bir satırda tanımlarız. Kaç kere döneceğini net bildiğimiz durumlarda mükemmeldir.",
                code: `for (let i = 1; i <= 5; i++) {
    console.log("Kutu " + i);
}`,
                execute: function(container) {
                    container.innerHTML = ""; // İçeriyi temizle
                    for (let i = 1; i <= 5; i++) {
                        container.innerHTML += `<div class="output-item">Kutu ${i}</div>`;
                    }
                }
            },
            "while": {
                title: "while Döngüsü",
                description: "Sadece bir koşul belirtiriz. 'Bu koşul doğru (true) olduğu sürece çalışmaya devam et' anlamına gelir. Döngünün ne zaman biteceğini önceden bilmediğimiz, bir şarta bağladığımız durumlarda kullanılır. İçeride değişkeni artırmayı unutursak sonsuz döngüye girer!",
                code: `let sayac = 10;
while (sayac <= 50) {
    console.log(sayac);
    sayac += 10; // 10'ar 10'ar artır
}`,
                execute: function(container) {
                    container.innerHTML = "";
                    let sayac = 10;
                    while (sayac <= 50) {
                        container.innerHTML += `<div class="output-item" style="background:#dcfce3;">Sayac: ${sayac}</div>`;
                        sayac += 10;
                    }
                }
            },
            "doWhile": {
                title: "do...while Döngüsü",
                description: "While döngüsüne çok benzer ancak çok kritik bir farkı vardır: Koşul yanlış (false) olsa bile kod bloğu 'en az 1 kere' mutlaka çalışır. Çünkü önce işlemi yapar (do), sonra koşulu kontrol eder (while).",
                code: `let x = 100;
do {
    console.log("Koşul sağlamasa da ben 1 kez çalışırım! x: " + x);
    x++;
} while (x < 5); // 100, 5'ten küçük değil ama bir kez çalıştı.`,
                execute: function(container) {
                    container.innerHTML = "";
                    let x = 100;
                    do {
                        container.innerHTML += `<div class="output-item" style="background:#fee2e2;">Çalıştı! Değer: ${x}</div>`;
                        x++;
                    } while (x < 5);
                }
            },
            "forIn": {
                title: "for...in Döngüsü",
                description: "Özellikle Nesneler (Objects) içindeki özellikler (propertiler) üzerinde gezinmek için kullanılır. Dizilerde de çalışır ama genellikle objelerin anahtarlarını (keys) okumak için tercih edilir.",
                code: `const kullanici = { ad: "Çağdaş", yas: 40, sehir: "Ankara" };

for (let anahtar in kullanici) {
    console.log(anahtar + " : " + kullanici[anahtar]);
}`,
                execute: function(container) {
                    container.innerHTML = "";
                    const kullanici = { ad: "Çağdaş", yas: 40, sehir: "Ankara" };
                    for (let anahtar in kullanici) {
                        container.innerHTML += `<div class="output-item" style="background:#fef08a; display:block;"><b>${anahtar}</b> : ${kullanici[anahtar]}</div>`;
                    }
                }
            },
            "forOf": {
                title: "for...of Döngüsü",
                description: "Diziler (Arrays), Metinler (Strings) gibi tekrarlanabilir veri yapıları içinde gezinmek için harikadır. Dizinin indeks (sıra) numarasıyla uğraşmadan, doğrudan içindeki elemanları sırayla sana verir.",
                code: `const meyveler = ["Elma", "Armut", "Muz", "Çilek"];

for (let meyve of meyveler) {
    console.log("Meyve: " + meyve);
}`,
                execute: function(container) {
                    container.innerHTML = "";
                    const meyveler = ["🍎 Elma", "🍐 Armut", "🍌 Muz", "🍓 Çilek"];
                    for (let meyve of meyveler) {
                        container.innerHTML += `<div class="output-item" style="background:#fce7f3; font-size:1.2rem;">${meyve}</div>`;
                    }
                }
            }
        };

        // Ekrana verileri basan ana fonksiyon
        function loadLoop(loopType) {
            // Menü butonlarındaki aktiflik durumunu güncelle
            document.querySelectorAll('.menu-btn').forEach(btn => btn.classList.remove('active'));
            event.target.classList.add('active');

            // Verileri al
            const data = loopData[loopType];

            // HTML elemanlarını güncelle
            document.getElementById('title').innerText = data.title;
            document.getElementById('description').innerText = data.description;
            document.getElementById('code-block').innerText = data.code;
            
            // Çıktı alanını bul ve döngüyü çalıştırarak sonucu bas
            const outputBlock = document.getElementById('output-block');
            data.execute(outputBlock);
        }

        // Sayfa ilk yüklendiğinde varsayılan olarak 'for' döngüsünü aç
        window.onload = function() {
            loadLoop('for');
        };
    </script>
</body>
</html>
