# 📦 Proyecto Bazar — VB.NET Windows Forms

Aplicación de escritorio (.NET Framework 4.0) para la gestión integral de un
rubro ferretero / bazar. Permite administrar **productos**, **ventas**, **compras**
y **stock**, con persistencia en base de datos local (.sdf) y lógica de
validación en tiempo real.

Desarrollado como proyecto universitario, con interfaz construida en Windows Forms
y datos manejados mediante **DataSets tipados** y **TableAdapters**.

---

## ✨ ¿Qué hace?

- **Gestión de productos**: alta, consulta, modificación y baja. Cada producto
  tiene código, nombre, categoría, precio de compra, precio de venta y stock
  mínimo. Los precios solo aceptan números con una coma decimal.

- **Registro de ventas**: captura de la venta de un producto a un cliente, con
  fecha automática y visualización del historial. El formulario de ventas incluye
  código en "standby" para futuras mejoras (búsqueda de clientes por combo,
  vistas de datos).

- **Registro de compras**: alta de nuevas compras a proveedores, actualización
  automática del stock de productos y registro de la transacción. Al igual que
  ventas, incluye código en standby para filtrado por proveedor.

- **Validaciones en tiempo real**: el teclado solo permite números y una sola
  coma para los campos de precio (`SoloNumerosDecimales`), y solo números
  enteros para códigos e IDs (`SoloNumerosEnteros`). Los mensajes de error
  evitan que el usuario ingrese datos inválidos.

- **Persistencia**: los datos se guardan en un archivo **.sdf** (SQL Server
  Compact Edition) ubicado en la carpeta `bin/Debug/`, junto con el ejecutable.

---

## 🧱 Stack técnico

| Tecnología | Uso |
|---|---|
| **VB.NET** | Lenguaje de programación (code-behind de los forms) |
| **.NET Framework 4.0** | Entorno de ejecución |
| **Windows Forms** | Interfaz gráfica (16 forms: Inicio, Productos, Ventas, Compras, Contacto, etc.) |
| **DataSets tipados** (`BazarDataSet`) | Esquema de datos con tablas y TableAdapters |
| **TableAdapters** | Comunicación entre la UI y la base de datos local (.sdf) |
| **SQL Server Compact Edition (.sdf)** | Motor de base de datos incrustado, archivo único |
| **MsgBox** | Cuadros de diálogo para confirmaciones y validaciones |
| **KeyPress / KeyDown** | Validación de entrada de teclado (solo números/decimales) |
| **Visual Studio** | IDE para edición, compilación y publicación |

---

## 📁 Estructura

```
ProyectoBazar/
├── Proyecto~Bazar/                     # Proyecto Visual Studio (.sln, .csproj)
│   ├── Productos.vb / Ventas.vb / Compras.vb   # Forms principales
│   ├── Inicio.vb / Contacto.vb                 # Otras pantallas
│   ├── Validaciones.vb                         # Funciones de validación de teclado
│   ├── BazarDataSet.xsd / .xsc / .xss / .Designer.vb  # Dataset tipado
│   ├── BazarDataSet.Designer.vb                # Generación automática de TableAdapters
│   ├── My Project/                             # Configuración de recursos y ensamblado
│   ├── Bin/                                    # Ejecutable .exe y .sdf al compilar
│   ├── obj/                                    # Archivos de compilación temporales
│   └── Proyecto~Bazar.sln                      # Solución de Visual Studio
├── .gitignore                              # Ignora Bin/, obj/, .suo, .user
└── README.md                               # Este archivo
```

---

## 🚀 Clonar y preparar

Requisitos: **Visual Studio 2010** o superior (compatibilidad con .NET Framework 4.0).

```bash
# 1. Clonar
git clone https://github.com/EzequieLakodey/ProyectoBazar.git
cd ProyectoBazar
```

### Abrir en Visual Studio

- Abrí el archivo `Proyecto~Bazar.sln` con Visual Studio.
- Compilá la solución (`Build → Build Solution`).
- El ejecutable quedará en `Proyecto~Bazar/bin/Debug/Proyecto~Bazar.exe`.

### Ejecutar

```bash
# Desde la carpeta bin/Debug
.\Proyecto~Bazar.exe
```

---

## 🛠️ Funcionalidades clave y código destacado

### Validación de entrada de teclado (`Validaciones.vb`)

Dos funciones para filtrar qué puede escribir el usuario:

```vb
' Solo números decimales (0-9 y una coma)
Function SoloNumerosDecimales(ByVal tecla As KeyPressEventArgs, ByVal texto_actual As String) As Boolean

' Solo números enteros (0-9, Backspace, Enter, Tab)
Function SoloNumerosEnteros(ByVal tecla As KeyPressEventArgs) As Boolean
```

Ambas usan `AscW(tecla.KeyChar)` para obtener el código ASCII y permiten:
- Números (48-57)
- Backspace (8)
- Coma (44) — válida solo si aún no hay una en el texto
- Enter (13) y Tab (9)

### Carga de forms y DataSets (`Productos.vb`, `Ventas.vb`, `Compras.vb`)

Cada form `Load` ejecuta la misma secuencia:

1. `Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)` — guarda cambios pendientes.
2. Llena los TableAdapters (`VentasTableAdapter.Fill`, `ProductosTableAdapter.Fill`, etc.).
3. `Me.ProductosBindingSource.MoveLast()` — posiciona al último registro.
4. `CargarColumnasEnComboBox(...)` — pobla unComboBox con los nombres de las columnas para filtrado.

### Código en "standby" (Ventas.vb y Compras.vb)

Cada formulario incluye bloques comentados que estaban pensados para futuras
mejoras:

- Creación de `DataView` sobre el Dataset.
- Filtrado de valores únicos (clientes o proveedores).
- Asignación al `ComboBox` con `DisplayMember` y `ValueMember`.

Estos fragmentos fueron dejados como referencia para quien quiera implementar
el filtrado avanzado después de la versión inicial.

---

## 🗂️ Base de datos local (.sdf)

El archivo `Bazar.sdf` se genera automáticamente en `Proyecto~Bazar/bin/Debug/`
al compilar. Contiene las tablas:

- **Productos**: ID_Producto (PK), Nombre, Categoría, Precio_Compra, Precio_Venta, Stock, Stock_Mínimo.
- **Ventas**: ID_Venta (PK), ID_Producto (FK), ID_Cliente, Fecha, Total.
- **Compras**: ID_Compra (PK), ID_Proveedor (FK), ID_Producto (FK), Fecha, Cantidad, Costo_Total.

No es necesario instalar nada aparte de .NET Framework: el archivo .sdf se
usa directamente como origen de datos en los TableAdapters.

---

## 📸 Capturas (opcional)

No hay capturas de pantalla incluidas en este repositorio, pero la interfaz
consiste en un menú principal con íconos que abren los forms de:
Productos, Ventas, Compras y Contacto, cada uno con grids, textboxes,
dateTimePickers y comboboxes para la navegación y filtrado de datos.

---

## 🗺️ Roadmap / ideas futuras

- [ ] Implementar el código "standby" para búsqueda de clientes/proveedores
      por combo.
- [ ] Agregar Reportes (Crystal Reports o printing) para facturas y listados.
- [ ] Sincronizar la base .sdf con una instalación de SQL Server Express en red.
- [ ] Agregar perfiles de usuario y permisos de acceso.
- [ ] Modernizar a .NET 6 / .NET 8 y migrar a WPF o MAUI.

---

## 📄 Licencia

Sin licencia definida todavía. Uso educativo / proyecto universitario.