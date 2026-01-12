# NET10-eShop

A **full-stack e‑commerce system** built as part of a professional-grade course, applying **modern .NET backend architecture patterns** and real-world engineering practices.

This project is intentionally treated like a production system rather than a demo, focusing on **architecture, maintainability, and clean workflows**.

---

## 🎯 Goals
- Practice **Clean Architecture**, **DDD**, and **Vertical Slice Architecture** in a realistic system
- Apply **CQRS**, messaging, caching, and API gateway patterns
- Use **Git and GitHub** with production-level discipline (PRs, protected branches, clean history)
- Build a portfolio-ready project that reflects real-world backend engineering

---

## 🏗️ Architecture Overview
The system is organized as a **modular monorepo**, with clear separation by bounded context.

**Key architectural choices:**
- **Clean Architecture** for dependency control
- **DDD** for modeling business domains
- **Vertical Slice Architecture** for feature isolation
- **CQRS** for clear read/write separation
- **Mediator pattern** via MediatR

Each feature is implemented as a **vertical slice** (command/query + handler + validation + persistence).

---

## 🧩 Core Patterns & Principles
- SOLID principles
- CQRS
- Mediator
- Decorator
- Options pattern
- Publish / Subscribe
- Caching
- API Gateway

---

## 🛠️ Tech Stack

### Backend
- .NET 10
- ASP.NET Core
- MediatR
- Carter
- FluentValidation
- Mapster

### Persistence
- PostgreSQL
- SQLite
- SQL Server
- Document DB (via Marten)
- Redis (caching)

### Messaging & Communication
- MassTransit
- RabbitMQ
- gRPC (sync)
- Publish/Subscribe (async)
- YARP API Gateway

### Infrastructure
- Docker & Docker Compose

---

## 🧪 Development Workflow
- `development` is the **default branch**
- `main` contains **stable, demo-ready releases**
- All changes go through **feature branches + Pull Requests**
- Feature branches are **short-lived and slice-oriented**
- PRs are **squash-merged** to keep a clean history

---

## 🚧 Project Status
🚀 Initial setup phase

Next steps:
- Solution and folder structure
- Catalog bounded context
- First vertical slices

---

## 📌 Notes
This project evolves incrementally. Architecture and documentation will be refined as new bounded contexts and features are introduced.

