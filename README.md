# Sieb des Eratosthenes

Eine Windows Forms Anwendung in C#, die das mathematische Verfahren "Sieb des Eratosthenes" zur Berechnung von Primzahlen visualisiert.

## 📋 Beschreibung

Diese Anwendung implementiert das antike mathematische Verfahren des Siebs des Eratosthenes. Das Sieb des Eratosthenes ist ein Algorithmus zur Berechnung aller Primzahlen bis zu einer bestimmten Grenze.

**Funktionsweise:**
- Die Zahlen werden grafisch auf Buttons dargestellt
- Der Algorithmus markiert Vielfache von Primzahlen (2, 3, 5, 7, ...) mit verschiedenen Farben
- Zahlen, die nicht durch diese Zahlen teilbar sind, werden als Primzahlen gekennzeichnet
- Die gefundenen Primzahlen werden in der Anwendung angezeigt

## 🎯 Features

- **Visuelle Darstellung**: Die Zahlen werden auf farblich gekennzeichneten Buttons angezeigt
- **Farbcodierung**:
  - Rot: Vielfache von 2
  - Grün: Vielfache von 3
  - Blau: Vielfache von 5
  - Gelb: Vielfache von 7
  - Dunkelcyan: Primzahlen
- **Ergebnisanzeige**: Gefundene Primzahlen werden in einer Textbox aufgelistet

## 🛠️ Technologie

- **Sprache**: C#
- **Framework**: .NET Framework 4.8
- **UI-Framework**: Windows Forms
- **Entwicklungsumgebung**: Visual Studio

## 📁 Projektstruktur

```
Sieb des Eratosthenes/
├── Form1.cs                 # Hauptformular mit Algorithmus-Logik
├── Form1.Designer.cs        # Automatisch generierte UI-Komponenten
├── Form1.resx              # Ressourcendatei
├── Program.cs              # Einstiegspunkt der Anwendung
├── App.config              # Konfigurationsdatei
└── Properties/             # Projekt-Metadaten und Einstellungen
```

## 🚀 Verwendung

1. Öffne das Projekt in Visual Studio
2. Kompiliere die Anwendung (Strg + Shift + B)
3. Starte das Programm (F5)
4. Klicke auf den Button "Primzahlen", um den Algorithmus auszuführen
5. Die berechneten Primzahlen werden unten im Display angezeigt

## 💡 Funktionsweise des Algorithmus

Das Sieb des Eratosthenes arbeitet nach folgendem Prinzip:

1. Erstelle eine Liste aller Zahlen von 2 bis zur Obergrenze
2. Markiere das erste Element (2) als Primzahl
3. Entferne alle Vielfachen von 2 aus der Liste
4. Wechsle zur nächsten nicht markierten Zahl und wiederhole Schritte 2-3
5. Fortfahren, bis alle Zahlen verarbeitet sind

## 📝 Lizenz

Dieses Projekt wurde als Schulprojekt der Gruppe 4 erstellt.
Copyright © 2021

## 👥 Gruppe 4

Schulprojekt zur mathematischen Visualisierung des Siebs des Eratosthenes.

---

**Hinweis**: Dieses Projekt dient zu Lehr- und Demonstrationszwecken.
