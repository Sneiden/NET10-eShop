# Contributing to NET10-eShop

Thank you for your interest in this project.

Although **NET10-eShop** is developed as a solo course project, it intentionally follows **professional, production-grade workflows**. This document defines the conventions used throughout the repository.

---

## 🌿 Branching Strategy

### Permanent branches
- **`develop`** – Default branch, active integration branch
- **`main`** – Stable, demo-ready releases only

Direct commits to these branches are **not allowed**.
All changes must go through Pull Requests.

---

## 🌱 Local Branch Naming

Local branches must follow this convention:

```
<prefix>/<short-description>
```

### Allowed prefixes

| Prefix | Purpose |
|------|--------|
| `feature/` | New business functionality or vertical slice |
| `bugfix/` | Fixing incorrect behavior |
| `refactor/` | Internal restructuring without behavior change |
| `chore/` | Non-functional maintenance |
| `infra/` | Infrastructure, Docker, messaging, gateway |
| `test/` | Tests only |
| `docs/` | Documentation only |

### Examples
```
feature/catalog-create-product
feature/cart-add-item
bugfix/order-transaction
infra/docker-compose
refactor/move-to-vertical-slices
```

---

## 🧩 Vertical Slice Principle

This project follows **Vertical Slice Architecture**.

**Rules:**
- One branch = one vertical slice
- One Pull Request = one slice
- One squash commit = one slice

A slice includes everything required to fulfill a single use case:
- Command or query
- Handler
- Validation
- Persistence
- API endpoint
- Messaging (if applicable)

---

## 📝 Commit Message Convention

Commits follow **Conventional Commits**:

```
<type>(<scope>): <description>
```

### Common types
- `feat` – New functionality
- `fix` – Bug fix
- `refactor` – Code restructuring
- `chore` – Maintenance or tooling
- `infra` – Infrastructure changes
- `docs` – Documentation
- `test` – Tests

### Examples
```
feat(cart): add item to cart
fix(order): wrap checkout in transaction
infra(docker): add rabbitmq container
docs(readme): update architecture section
```

---

## 🔀 Pull Request Workflow

1. Branch off from `development`
2. Keep branches short-lived
3. Rebase locally if needed
4. Open a Pull Request targeting `development`
5. Use **Squash and Merge**
6. Delete branch after merge

### Pull Request expectations
A Pull Request should include:
- Clear title describing the change
- Description explaining **what** and **why**
- Testing notes when applicable

---

## 🚀 Merging & Releases

- All PRs merge into `development`
- `main` is updated only at milestones
- Releases are tagged (e.g. `v0.1.0`, `v1.0.0`)

---

## ⚠️ History & Safety Rules

- Force pushes are not allowed on protected branches
- Deleting protected branches is restricted
- History must remain clean and traceable

---

## 📌 Final Notes

These rules are intentionally strict to encourage:
- Clean Git history
- Clear architectural intent
- Real-world engineering discipline

Consistency is more important than perfection.

