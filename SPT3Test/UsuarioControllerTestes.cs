using Microsoft.AspNetCore.Mvc;
using Moq;
using TarefasSPT3.Controllers;
using TarefasSPT3.Models;
using TarefasSPT3.Repositorios.Interfaces;

namespace SPT3Test
{
    public class UsuarioControllerTests
    {
        private readonly UsuarioController _controller;
        private readonly Mock<IUsuarioRepositorio> _mockRepositorio;

        public UsuarioControllerTests()
        {
            _mockRepositorio = new Mock<IUsuarioRepositorio>();
            _controller = new UsuarioController(_mockRepositorio.Object);
        }

        [Fact]
        public async Task GetAllUsuarios_DeveRetornarListaDeUsuarios()
        {
            // Arrange
            var usuarios = new List<Usuario>
            {
                new Usuario { Nome = "Usuario 1", Email = "usuario1@teste.com" },
                new Usuario { Nome = "Usuario 2", Email = "usuario2@teste.com" }
            };

            _mockRepositorio.Setup(repo => repo.BuscarTodosUsuarios()).ReturnsAsync(usuarios);

            // Act
            var result = await _controller.GetAllUsuarios();

            // Assert
            var actionResult = Assert.IsType<ActionResult<List<Usuario>>>(result);
            var okResult = Assert.IsType<OkObjectResult>(actionResult.Result);
            var retornoUsuarios = Assert.IsType<List<Usuario>>(okResult.Value);
            Assert.Equal(2, retornoUsuarios.Count);
        }

        // Adicione mais testes para outras ações do controller
    }
}