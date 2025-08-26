# Desafio Asenjo Práticas de Programação

Este projeto é uma aplicação Windows Forms em C# desenvolvida para o desafio bimestral da disciplina de Práticas de Programação. O objetivo é criar um sistema CRUD de pessoas, utilizando banco de dados relacional (Access ou outro), com validações e preenchimento automático de endereço via CEP.

## Objetivo

Desenvolver um CRUD para cadastro de pessoas, armazenando as seguintes informações:

- **ID** (auto numeração)
- **Nome**
- **Telefone** (formato: (xx) xxxxx-xxxx)
- **E-mail**
- **CEP**
- **Estado** (preenchido automaticamente)
- **Cidade** (preenchido automaticamente)
- **Bairro** (preenchido automaticamente)
- **Rua** (preenchido automaticamente)
- **Número**
- **Complemento** (opcional)

## Funcionalidades

- Cadastro, edição, exclusão e listagem de pessoas
- Validação dos campos obrigatórios
- Validação de formato para telefone, e-mail e CEP usando RegEx
- Preenchimento automático de endereço via consulta ao CEP
- Interface amigável em Windows Forms

## Requisitos

- Todos os campos são obrigatórios, exceto complemento
- Telefone, e-mail e CEP validados por formato
- Estado, cidade, bairro e rua preenchidos automaticamente após digitação do CEP
- Número e complemento digitados e validados (complemento opcional)

## Como executar

1. Abra o arquivo de solução `.sln` no Visual Studio
2. Restaure os pacotes NuGet se necessário
3. Execute o projeto
4. Configure o banco de dados Access (ou outro relacional) conforme instruções internas do projeto

## Demonstração

Sugere-se gravar um vídeo demonstrando o funcionamento do sistema para facilitar a apresentação.

## Autores

Projeto desenvolvido por Lucas Barros, João Del, Rafael Omelczuk e Indalecio.

---

**Desafio proposto:**

> Desenvolver um CRUD para pessoas usando banco Access ou outro relacional. Para cada pessoa cadastrada: id, nome, telefone, e-mail, cep, estado, cidade, bairro, rua, número e complemento. Todos os campos obrigatórios, exceto complemento. Telefone, e-mail e CEP validados por formato (RegEx). Endereço preenchido automaticamente via CEP. Número e complemento digitados e validados (complemento opcional).
