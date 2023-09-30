# Gerenciador de Funcionario - Projeto ASP.NET Core

[![Licença](https://img.shields.io/badge/Licen%C3%A7a-MIT-blue)](https://github.com/luigiPerkoski/ApiFuncionario/blob/master/LICENSE)

## Descrição do Projeto

A API de Funcionários é um sistema de gerenciamento que oferece funcionalidades essenciais para manipulação de registros de funcionários em uma organização. Com endpoints bem definidos

## Funcionalidades Principais

### 1. Listar Funcionários
Retorna uma lista de todos os funcionários cadastrados.

**Endpoint:** `GET /funcionarios`
 
```json
[
  {
    "id": 1,
    "nome": "João Silva",
    "turno": "Noite",
    "departamento": "TI",
    "ativo": true
  },
  {
    "id": 2,
    "nome": "Maria Oliveira",
    "turno": "Manhã",
    "departamento": "Recursos Humanos",
    "ativo": false
  },
  {
    "id": 3,
    "nome": "Carlos Eduardo",
    "turno": "Tarde",
    "departamento": "Financeiro",
    "ativo": true
  }
]
```

### 2. Obter Funcionário por ID
Retorna os detalhes de um funcionário específico.

**Endpoint:** `GET /funcionarios/2`

```json
[
  {
    "id": 2,
    "nome": "Maria Oliveira",
    "turno": "Manhã",
    "departamento": "Recursos Humanos",
    "ativo": false
  }
]
```

### 3. Adicionar Funcionário
Cria um novo registro de funcionário.

**Endpoint:** `POST /funcionarios`

**Corpo da Requisição:**
```json
{
  "nome": "Nome do Funcionário",
  "turno": "Turno do Funcionario",
  "departamento": "Departamento do Funcionário",
  "ativo": true
}
```

### 4. Atualizar Funcionário
Atualiza os detalhes de um funcionário existente.

**Endpoint:** `PUT /funcionarios/{id}`

**Corpo da Requisição:**
```json
{
  "nome": "Novo Nome do Funcionário",
  "turno": "Turno do Funcionario",
  "departamento": "Novo Departamento do Funcionário",
  "ativo": true
}
```
### 5. Desativar Funcionário
Desativa um funcionário, tornando-o inativo no sistema.

**Endpoint:** `PUT /funcionarios/disable/3`

```json
[
  {
    "id": 3,
    "nome": "Carlos Eduardo",
    "turno": "Tarde",
    "departamento": "Financeiro",
    "ativo": false
  }
]
```

### 6. Excluir Funcionário
Remove um funcionário do sistema.

**Endpoint:** `DELETE /funcionarios/1`
```json
[
  {
    "id": 2,
    "nome": "Maria Oliveira",
    "turno": "Manhã",
    "departamento": "Recursos Humanos",
    "ativo": false
  },
  {
    "id": 3,
    "nome": "Carlos Eduardo",
    "turno": "Tarde",
    "departamento": "Financeiro",
    "ativo": true
  }
]
```
## Tecnologias Utilizadas

- **ASP.NET Core:** Um framework de código aberto para a construção de aplicativos modernos e de alto desempenho em C#.

- **MySQL:** Sistema de gerenciamento de banco de dados relacional para armazenar e recuperar informações financeiras.

- **C#:** Uma linguagem de programação versátil e poderosa utilizada para o desenvolvimento de aplicativos na plataforma .NET.

##Swagger
![Swagger]()