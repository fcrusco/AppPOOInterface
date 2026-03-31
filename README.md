Payment System - OOP & Dependency Injection
Este projeto demonstra a aplicação prática de conceitos avançados de Programação Orientada a Objetos (POO) em C#, focando em desacoplamento e extensibilidade através de Interfaces e Injeção de Dependência.

🇧🇷 Português
Descrição
O projeto simula um sistema de pagamentos onde a classe Pedido não conhece os detalhes de implementação das formas de pagamento (Cartão, Boleto ou Bitcoin). Isso é possível graças à interface IPagavel, que define um contrato obrigatório.

Conceitos Aplicados
Interface: Define o contrato IPagavel para garantir que qualquer forma de pagamento possua os métodos necessários.

Abstração: Uso de PagamentoBase para evitar repetição de código (DRY) e compartilhar atributos comuns (Valor, Data).

Polimorfismo: A classe Pedido trata diferentes objetos de forma genérica.

Injeção de Dependência (DI): A dependência é injetada via construtor, permitindo que o sistema seja extensível sem alterar o núcleo da regra de negócio (Open/Closed Principle).


---------------------------------------------------------
🇺🇸 English
Description
This project demonstrates a payment system where the Pedido (Order) class is decoupled from specific payment implementations (Credit Card, Bank Slip, or Bitcoin). This is achieved through the IPagavel interface, which establishes a formal contract.

Key Concepts
Interface: Defines the IPagavel contract to ensure every payment method implements required behaviors.

Abstraction: Utilizes PagamentoBase to prevent code duplication (DRY) and manage shared attributes (Amount, Date).

Polymorphism: The Pedido class interacts with different payment types through a generic reference.

Dependency Injection (DI): Dependencies are injected via constructor, ensuring the system is extensible without modifying core business logic (Open/Closed Principle).


---------------------------------------------------------
🇪🇸 Español
Descripción
Este proyecto ilustra un sistema de pagos donde la clase Pedido (Pedido) está desacoplada de las implementaciones específicas de pago (Tarjeta, Boleto o Bitcoin). Esto se logra mediante la interfaz IPagavel, que define un contrato obligatorio.

Conceptos Clave
Interfaz: Define el contrato IPagavel para garantizar que cualquier método de pago cumpla con los comportamientos requeridos.

Abstracción: Uso de PagamentoBase para evitar la duplicación de código (DRY) y compartir atributos comunes (Valor, Fecha).

Polimorfismo: La clase Pedido trata diferentes objetos de manera genérica.

Inyección de Dependencia (DI): La dependencia se inyecta a través del constructor, permitiendo que el sistema sea extensible sin alterar la lógica de negocio principal (Principio de Abierto/Cerrado).

🛠️ Tecnologias / Technologies / Tecnologías
C#

.NET
OOP Principles (SOLID)

🚀 Extensibilidade / Extensibility
Para adicionar novas formas de pagamento (ex: Pix), basta criar uma nova classe que herde de PagamentoBase e implemente IPagavel. A classe Pedido não precisa ser alterada.
