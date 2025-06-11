# Componentes do Grupo
- Arthur dos Santos Rodrigues (4rkh)  
- Luccas Nicolete Meireles (LuccasNico)  
- Rafael Michalewicz Rodrigues (Michalewicz)  
- Sandro Gabriel dos Santos de Jesus (Sandro-Gab)

# Aplicativo LES - PRIMEGadgets

Este projeto é uma aplicação desktop multiutilitária desenvolvida em **C# com .NET** no **Microsoft Visual Studio 2022**, para a disciplina de Laboratório de Engenharia de Software (LES). A aplicação visa centralizar diversas ferramentas de gestão pessoal para facilitar a organização do usuário.

## Funcionalidades

- **Calculadora e Conversor de Unidades:** Operações matemáticas básicas e conversões entre unidades de temperatura, peso e comprimento.
- **Agenda de Contatos:** Cadastro, edição, exclusão e visualização de contatos. Suporte a filtros de busca e paginação.
- **Calendário:** Registro de eventos, datas importantes e compromissos, com integração com contatos.
- **Lista de Rotina Diária:** Criação e gerenciamento de tarefas diárias, com histórico semanal e visualização por gráficos.
- **Lembretes:** Gerenciamento de lembretes ativos e concluídos com destaque visual.
- **Planejador Financeiro:** Adição, edição e remoção de gastos, com visualização por gráficos e filtros (diário, mensal, anual).
- **Gerenciador de Senhas:** Armazenamento seguro de logins e senhas criptografadas. Inclui gerador de senhas fortes personalizável.

## Como Executar

Siga os passos abaixo para clonar, abrir e executar o projeto PRIMEGadgets corretamente:

1. **Clone o repositório**

   Abra o terminal ou Git Bash e execute:
   git clone https://github.com/4rkh/PRIMEGadgets

2. **Abra o projeto no Visual Studio**

   - Inicie o **Microsoft Visual Studio 2022**.
   - Vá em **File > Open > Project/Solution...**
   - Navegue até a pasta onde o repositório foi clonado e selecione o arquivo `.sln` da solução (caso exista).

3. **Restaure dependências (se necessário)**

   - Vá até o menu **Tools > NuGet Package Manager > Manage NuGet Packages for Solution...**
   - Clique em **Restore** para garantir que todas as bibliotecas estejam atualizadas.

4. **Compile o projeto**

   - No topo da interface do Visual Studio, selecione o modo **Debug** ou **Release**.
   - Clique em **Build > Build Solution** ou pressione `Ctrl+Shift+B`.

5. **Execute o aplicativo**

   - Pressione `F5` ou clique em **Start** para rodar o PRIMEGadgets.

6. **Dica**: Para melhor experiência, execute em tela maximizada e navegue pelo menu principal (`TelaPrincipal.cs`).

## Tecnologias Utilizadas

- C# (.NET Framework)
- Windows Forms
- Microsoft Visual Studio 2022
- System.IO para manipulação de arquivos
- Criptografia nativa com File.Encrypt e File.Decrypt
- Gráficos com bibliotecas de visualização do .NET

---
## Padrão de Variáveis

Nome das Telas: `IdentificaçãoDaTela` + `NomeDoMódulo`
Exemplo: `MainContato`

Componentes da Tela:
`TipoDoComponente` + `NomeDaTela` + `IdentificaçãoDoComponente`
Exemplo: `lbMainContatosTitulo`

Abreviações:
- `lb` : Label
- `cb` : ComboBox
- `bt` : Button
- `dt` : DataGridView
- `camp` : TextBox
- `ct` : Chart

Desenvolvido com fins acadêmicos para a FATEC Praia Grande – 2025.
