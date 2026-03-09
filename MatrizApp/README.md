# 🔢 MatrizApp — Visualizador de Matriz em C# (Windows Forms)

Projeto desenvolvido como atividade acadêmica utilizando **C# com Windows Forms (.NET 6)**.  
Demonstra o uso de **matrizes bidimensionais** e **versionamento com Git**.

---

## 🖥️ O que o programa faz

- Exibe uma **matriz 3×3** visualmente na tela com células coloridas
- Mostra os **índices [i,j]** de cada posição da matriz
- Permite **gerar valores aleatórios** com um clique
- Exibe **informações** da matriz: soma, média, maior e menor valor
- Permite **resetar** para os valores padrão (1 a 9)

---

## 📁 Estrutura do Projeto

```
MatrizApp/
├── Program.cs           → Ponto de entrada do aplicativo
├── Form1.cs             → Lógica principal (eventos e algoritmos)
├── Form1.Designer.cs    → Layout do formulário (gerado automaticamente)
├── MatrizApp.csproj     → Configuração do projeto .NET
├── .gitignore           → Arquivos ignorados pelo Git
└── README.md            → Este arquivo
```

---

## 🚀 Como executar

### Pré-requisitos
- Visual Studio 2022 (ou VS Code com extensão C#)
- .NET 6 SDK ou superior
- Windows (obrigatório para Windows Forms)

### Passos
1. Clone ou baixe o projeto
2. Abra o arquivo `MatrizApp.csproj` no Visual Studio
3. Pressione **F5** para compilar e executar

---

## 📚 Conceitos de C# utilizados

| Conceito | Onde é usado |
|---|---|
| `int[,] matriz` | Declaração de matriz 2D |
| `new int[linhas, colunas]` | Instanciação da matriz |
| `matriz[i, j]` | Acesso por índice linha/coluna |
| Laço `for` aninhado | Percorrer todos os elementos |
| `Random` | Geração de valores aleatórios |
| `Graphics` / `Paint` | Desenho visual da matriz |
| Eventos (`Click`, `Paint`) | Interação com o usuário |

---

## 🗂️ Versionamento com Git

### Inicializar o repositório (primeira vez)

```bash
git init
git add .
git commit -m "feat: projeto inicial - visualizador de matriz 3x3"
```

### Fluxo de trabalho sugerido

```bash
# Após cada alteração significativa:
git add .
git commit -m "feat: descrição do que foi feito"

# Exemplos de mensagens de commit:
git commit -m "feat: adiciona geração de valores aleatórios"
git commit -m "fix: corrige cálculo da média"
git commit -m "style: melhora cores da interface"
git commit -m "docs: atualiza README"
```

### Enviar para o GitHub

```bash
git remote add origin https://github.com/seu-usuario/MatrizApp.git
git branch -M main
git push -u origin main
```

---

## 💡 Possíveis melhorias futuras

- [ ] Permitir alterar o tamanho da matriz (ex: 4×4, 5×5)
- [ ] Adicionar soma de linhas e colunas
- [ ] Implementar transposição da matriz
- [ ] Permitir editar os valores clicando nas células
