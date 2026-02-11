# ⏱ WorkTime Tracker

Sistema web para gestión y control de horas laborales orientado a empleados y pequeñas empresas.

Permite registrar horas trabajadas, calcular ingresos automáticamente según tarifa configurada y generar reportes mensuales y diarios. Incluye soporte multi-empresa con autenticación basada en JWT.

---

## 🚀 Objetivo del Proyecto

Desarrollar una aplicación full-stack profesional con arquitectura limpia (Clean Architecture), autenticación segura y soporte multi-tenant (empresas + empleados).

Proyecto académico con proyección comercial.

---

## 🏗 Arquitectura

### Backend

* ASP.NET Core Web API
* Clean Architecture
* Entity Framework Core
* PostgreSQL
* JWT Authentication
* Role-based Authorization

### Frontend

* React + Vite
* Tailwind CSS
* Axios
* Context API / Zustand

### Deploy (Entorno Productivo)

* Backend: Railway / Render
* Base de datos: PostgreSQL (cloud)
* Frontend: Vercel

---

## 👥 Modelo de Negocio

El sistema permite:

* Empresas con múltiples empleados
* Usuarios individuales (modo freelance)
* Roles:

  * AdminEmpresa
  * Empleado

---

## 📊 Funcionalidades Iniciales (v1)

### Empleado

* Registrar horas trabajadas
* Editar registros
* Visualizar total diario
* Visualizar total mensual
* Visualizar mes anterior
* Configurar tarifa por hora

### AdminEmpresa

* Crear empleados
* Visualizar reportes por empleado
* Visualizar reporte general mensual

---

## 🔐 Seguridad

* Autenticación con JWT
* Autorización basada en roles
* Aislamiento de datos por empresa (multi-tenant)

---

## 🗂 Modelo de Datos Principal

### Empresa

* Id
* Nombre
* FechaCreacion

### Usuario

* Id
* Nombre
* Email
* PasswordHash
* Rol
* EmpresaId (nullable)
* TarifaPorHora
* Sector
* LugarTrabajo

### RegistroHoras

* Id
* UsuarioId
* Fecha
* HorasTrabajadas
* Observaciones

---

## 🛠 Roadmap

### Fase 1

* Autenticación
* CRUD de RegistroHoras
* Cálculo de totales

### Fase 2

* Reportes avanzados
* Dashboard con gráficos
* Filtros por rango

### Fase 3

* Exportación a PDF / Excel
* Control de horas extra
* Escalabilidad SaaS

---

## 🎓 Proyecto Académico

Desarrollado como práctica avanzada full-stack para aplicar:

* Arquitectura limpia
* Seguridad JWT
* Multi-tenant
* Buenas prácticas de desarrollo colaborativo

---

## 📌 Estado

En desarrollo.
