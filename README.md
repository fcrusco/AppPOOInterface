# Sistema de Pagamentos - POO & Injeção de Dependência

Este projeto demonstra a aplicação prática de conceitos avançados de Programação Orientada a Objetos (POO) em C#, focando em desacoplamento e extensibilidade através de Interfaces e Injeção de Dependência via Construtor.

---

## 🇧🇷 Português

### 📝 Descrição
O projeto simula um fluxo de e-commerce onde a classe `Pedido` é totalmente independente das implementações concretas de pagamento. Seja por **Cartão**, **Boleto** ou **Bitcoin**, o `Pedido` apenas exige que o objeto recebido cumpra o contrato definido pela interface `IPagavel`.

### 🚀 Pontos Fortes do Design
* **Desacoplamento:** A classe `Pedido` não sabe *como* o pagamento é feito, apenas *que* ele deve ser processado.
* **Injeção de Dependência (DI):** A forma de pagamento é injetada no construtor do `Pedido`, permitindo trocar a estratégia de pagamento em tempo de execução.
* **Open/Closed Principle (SOLID):** O sistema está **aberto para extensão** (podemos adicionar Pix, por exemplo) mas **fechado para alteração** (não precisamos mexer na classe `Pedido` para isso).

---

## 🇺🇸 English

### 📝 Description
This project demonstrates a payment workflow where the `Pedido` (Order) class is completely independent of specific payment implementations. Whether using **Credit Card**, **Bank Slip**, or **Bitcoin**, the `Pedido` class only requires the object to fulfill the contract defined by the `IPagavel` interface.

### 🚀 Design Highlights
* **Decoupling:** The `Pedido` class doesn't know *how* the payment is processed, only *that* it must be processed.
* **Dependency Injection (DI):** The payment method is injected via the `Pedido` constructor, allowing for easy swapping of payment strategies at runtime.
* **Open/Closed Principle (SOLID):** The system is **open for extension** (e.g., adding Pix) but **closed for modification** (no changes needed in the `Pedido` class).

---

## 🇪🇸 Español

### 📝 Descripción
Este proyecto demuestra un flujo de pago donde la clase `Pedido` es totalmente independiente de las implementaciones concretas. Ya sea mediante **Tarjeta**, **Boleto** o **Bitcoin**, la clase `Pedido` solo exige que el objeto cumpla con el contrato definido por la interfaz `IPagavel`.

### 🚀 Aspectos Destacados del Diseño
* **Desacoplamiento:** La clase `Pedido` no sabe *cómo* se procesa el pago, solo *que* debe procesarse.
* **Inyección de Dependencia (DI):** El método de pago se inyecta a través del constructor de `Pedido`, permitiendo cambiar las estrategias de pago fácilmente.
* **Principio de Abierto/Cerrado (SOLID):** El sistema está **abierto para extensión** (ej. añadir Pix) pero **cerrado para modificación** (no es necesario cambiar la clase `Pedido`).

---

## 🛠️ Tecnologias / Stack
* **Language:** C#
* **Framework:** .NET
* **Pattern:** Dependency Injection (Constructor Injection)
* **Principles:** SOLID (Single Responsibility, Open/Closed, Dependency Inversion)

---

## 📂 Estrutura de Pastas / Folder Structure
* `/Interface`: Contém a `IPagavel` (O Contrato).
* `/Model`: Contém a `PagamentoBase` (Abstração) e as classes concretas.
* `Program.cs`: Ponto de entrada com o menu de decisão e injeção da dependência.
