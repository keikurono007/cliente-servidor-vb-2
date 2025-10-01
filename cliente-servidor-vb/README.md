# 🚀 Aplicación Cliente/Servidor VB.NET

Aplicación cliente-servidor funcional desarrollada completamente en **VB.NET** con comunicación TCP.

## 📁 Estructura del Proyecto

```
cliente-servidor-vb/
├── Servidor/                    # 🖖️ Aplicación Servidor
│   └── Servidor/
│       ├── Form1.vb            # Lógica del servidor TCP
│       ├── Form1.Designer.vb   # Diseño de interfaz
│       ├── Program.vb          # Punto de entrada
│       ├── Servidor.vbproj     # Proyecto VB.NET
│       └── bin/               # Archivos compilados
├── Cliente/                     # 🌐 Aplicación Cliente
│   └── Cliente/
│       ├── Form1.vb            # Lógica del cliente TCP
│       ├── Form1.Designer.vb   # Diseño de interfaz
│       ├── Program.vb          # Punto de entrada
│       ├── Cliente.vbproj      # Proyecto VB.NET
│       └── bin/               # Archivos compilados
└── README.md                    # Esta documentación
```

## 🚀 Características

### Servidor VB.NET
- ✅ **Interfaz Windows Forms** completa y funcional
- ✅ **Servidor TCP** que escucha en puerto configurable (defecto: 8080)
- ✅ **Manejo de múltiples clientes** simultáneos con threads separados
- ✅ **Log de actividad** en tiempo real con timestamps
- ✅ **Contador de clientes** conectados en tiempo real
- ✅ **Confirmación automática** de mensajes recibidos
- ✅ **Control de estado** visual (Activo/Detenido)
- ✅ **Botones Iniciar/Detener** servidor fácil de usar
- ✅ **Validación de puertos** y manejo de errores

### Cliente VB.NET
- ✅ **Interfaz Windows Forms** intuitiva y moderna
- ✅ **Conexión TCP** a servidor configurable (localhost:8080 por defecto)
- ✅ **Envío de mensajes** personalizables con campo de texto
- ✅ **Recepción automática** de respuestas del servidor
- ✅ **Log de actividad** en tiempo real con timestamps
- ✅ **Estado de conexión** visual (Conectado/Desconectado)
- ✅ **Botones Connect/Disconnect** para gestión de conexión
- ✅ **Envío con Enter** para rápidez de uso
- ✅ **Validación de mensajes** y campos obligatorios

## 🛠️ Instalación y Uso

### Prerrequisitos
- **.NET 8.0** o superior
- **Visual Studio** o **Visual Studio Code**

### Compilation
```bash
# Compilar servidor
cd Servidor/Servidor
dotnet build

# Compilar cliente
cd ../../Cliente/Cliente
dotnet build
```

### Ejecución
```bash
# Opción 1: PowerShell individual
# Ventana 1 - Servidor
cd Servidor\Servidor
dotnet run

# Ventana 2 - Cliente
cd Cliente\Cliente
dotnet run

# Opción 2: Desde directorio raíz
dotnet run --project Servidor/Servidor/Servidor.vbproj
dotnet run --project Cliente/Cliente/Cliente.vbproj
```

## 🎮 Uso de la Aplicación

### Servidor
1. **Ejecutar** el servidor (`dotnet run`)
2. **Configurar puerto** (por defecto: 8080) si es necesario
3. **Hacer clic en "Iniciar Servidor"**
4. **Observar cambio de estado** a "Activo" (verde)
5. **Esperar conexiones** de clientes
6. **Ver mensajes** recibidos en el log con timestamps
7. **Monitorear clientes** conectados en contador
8. **Usar "Detener Servidor"** cuando sea necesario

### Cliente
1. **Ejecutar** el cliente (`dotnet run`)
2. **Verificar configuración** servidor: localhost, puerto: 8080
3. **Hacer clic en "Conectar"**
4. **Observar cambio de estado** a "Conectado" (verde)
5. **Escribir mensaje** en el campo de texto
6. **Hacer clic en "Enviar"** o presionar Enter
7. **Ver mensaje enviado** y respuesta recibida en el log
8. **Continuar enviando** más mensajes
9. **Usar "Desconectar"** al terminar

## 🔧 Configuración

### Puertos
- **Servidor**: Puerto configurable (por defecto: 8080)
- **Cliente**: Debe usar el mismo puerto del servidor

### Red
- **Local**: Usar `localhost` o `127.0.0.1`
- **Red local**: Usar la IP del servidor en la red

## 📡 Comunicación

### Protocolo TCP
- **Conexión**: Cliente se conecta al servidor
- **Mensajes**: Texto plano en UTF-8
- **Respuestas**: Confirmación automática del servidor
- **Desconexión**: Cierre limpio de conexiones

### Flujo de Mensajes
1. **Cliente envía** mensaje al servidor
2. **Servidor recibe** y registra el mensaje
3. **Servidor envía** confirmación al cliente
4. **Cliente recibe** y muestra la respuesta

## 🚀 Ejemplo de Uso Paso a Paso

### Escenario 1: Prueba Local (Misma Computadora)
```bash
# Terminal 1 - Iniciar Servidor
cd Servidor\Servidor
dotnet run
# Hacer clic en "Iniciar Servidor"
# Esperar estado "Activo" (verde)

# Terminal 2 - Conectar Cliente
cd Cliente\Cliente
dotnet run
# Hacer clic en "Conectar"
# Escribir: "Hola desde el cliente!"
# Hacer clic en "Enviar" o presionar Enter
# Ver respuesta automática del servidor
```

### Escenario 2: Red Local (Diferentes PCs)
```bash
# PC Servidor (IP: 192.168.1.100)
cd Servidor\Servidor
dotnet run
# Configurar puerto: 8080
# Hacer clic en "Iniciar Servidor"

# PC Cliente 
cd Cliente\Cliente  
dotnet run
# Servidor: 192.168.1.100
# Puerto: 8080
# Conectar y enviar mensajes
```

### Flujo de Comunicación Esperado
1. **Cliente envía**: "Mensaje de prueba"
2. **Servidor recibe**: Registra en log
3. **Servidor responde**: "Mensaje recibido: Mensaje de prueba"
4. **Cliente recibe**: Muestra respuesta automática
5. **Ambos logs**: Muestran toda la comunicación con timestamps

## 🔒 Características Técnicas

- **Threading**: Manejo de múltiples clientes en hilos separados
- **TCP Sockets**: Comunicación confiable
- **UTF-8 Encoding**: Soporte completo de caracteres
- **Error Handling**: Manejo robusto de errores
- **Resource Management**: Liberación automática de recursos

## 📝 Logs

### Servidor
- **Inicio/detención** del servidor
- **Conexiones/desconexiones** de clientes
- **Mensajes recibidos** con timestamps
- **Errores de comunicación**

### Cliente
- **Conexión/desconexión** con servidor
- **Mensajes enviados** y respuestas recibidas
- **Errores de conexión**

## 🆘 Solución de Problemas

### El Servidor No Inicia
1. **Verificar que el puerto esté libre**
2. **Comprobar permisos** de red
3. **Revisar firewall/antivirus**

### El Cliente No Conecta
1. **Verificar que el servidor esté ejecutándose**
2. **Comprobar IP y puerto** correctos
3. **Verificar conectividad** de red

### Error de Comunicación
1. **Verificar conexión** entre cliente y servidor
2. **Comprobar puertos** coincidentes
3. **Revisar logs** en ambas aplicaciones

## 🔄 Personalización y Extensiones

### Modificar Funcionalidades
- **Servidor**: Editar `Form1.vb` y `Form1.Designer.vb`
- **Cliente**: Editar `Form1.vb` y `Form1.Designer.vb`

### Añadir Nuevas Características
- **Nuevos tipos de mensajes**: Extender el protocolo de comunicación
- **Autenticación**: Añadir sistema de login con usuario/contraseña
- **Encriptación**: Implementar cifrado AES o TLS
- **Archivos**: Permitir envío y descarga de archivos
- **Chat en tiempo real**: Mostrar conversaciones de múltiples usuarios
- **Base de datos**: Guardar mensajes en SQL Server o SQLite

### Estructura de Archivos Implementada
```
Form1.vb              # Lógica de negocio (TCP, threading, eventos)
Form1.Designer.vb     # Diseño de interfaz (controles, layouts)
Program.vb           # Punto de entrada de la aplicación
*.vbproj             # Configuración del proyecto .NET 8.0
```

## 📚 Documentación Técnica

### Clases Principales Implementadas
- **Form1** (Servidor): Interfaz y lógica del servidor TCP
- **Form1** (Cliente): Interfaz y lógica del cliente TCP
- **TcpListener**: Escucha conexiones entrantes
- **TcpClient**: Establece conexiones cliente
- **NetworkStream**: Flujo de datos bidireccional
- **Thread**: Manejo de conexiones concurrentes

### Arquitectura de Hilos
- **Servidor**: 
  - Hilo principal UI (botones, logs)
  - Hilo de aceptación de conexiones (`AceptarConexiones`)
  - Header independiente por hilo cliente (`ManejarCliente`)
- **Cliente**:
  - Hilo principal UI (interfaz, envío)
  - Hilo de escucha (`EscucharRespuestas`)

### Protocolo TCP Implementado
- **Conexión**: Cliente → Servidor (puerto 8080)
- **Mensajes**: UTF-8 texto plano
- **Respuestas**: Confirmación automática "Mensaje recibido: {contenido}"
- **Desconexión**: Liberación limpia de recursos

## ✅ Estado del Proyecto

**✅ COMPLETAMENTE IMPLEMENTADO Y FUNCIONAL**

- ✅ Servidor TCP con interfaz completa
- ✅ Cliente TCP con interfaz completa  
- ✅ Comunicación bidireccional funcionando
- ✅ Manejo de múltiples clientes
- ✅ Logs en tiempo real con timestamps
- ✅ Validación de errores y entrada de usuario
- ✅ Liberación adecuada de recursos
- ✅ Compilación exitosa sin errores
- ✅ Documentación actualizada y completa

### Versión Actual: 2.0 - Funcional Completo
- **.NET Framework**: 8.0
- **Plataforma**: Windows
- **Lenguaje**: VB.NET
- **Tipo**: Windows Forms Application

---

**Desarrollado con ❤️ usando VB.NET para aplicaciones cliente-servidor robustas**



