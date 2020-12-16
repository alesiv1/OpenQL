using SharpGL;
using System;
using System.Windows.Forms;

namespace OpenQLProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openglControl1_OpenGLDraw(object sender, RenderEventArgs args)
        {
            // Создаем экземпляр
            OpenGL gl = this.openglControl1.OpenGL;

            // Очистка экрана и буфера глубин
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            // Сбрасываем модельно-видовую матрицу
            gl.LoadIdentity();

            // Двигаем перо вглубь экрана
            gl.Translate(0.0f, 0.0f, -5.0f);

            gl.Begin(OpenGL.GL_TRIANGLES);

            // Указываем цвет вершин
            gl.Color(1f, 1f, 1f);

            gl.Vertex(-1f, -1f);
            gl.Vertex(0f, 1f);
            gl.Vertex(1f, -1f);

            // Завершаем работу
            gl.End();
            gl.End();
        } 

        private void openglControl1_Resize(object sender, EventArgs e)
        {
            //  Get the OpenGL object.
            OpenGL gl = this.openglControl1.OpenGL;

            //  Set the projection matrix.
            gl.MatrixMode(OpenGL.GL_PROJECTION);

            //  Load the identity.
            gl.LoadIdentity();

            //  Create a perspective transformation.
            gl.Perspective(60.0f, (double)Width / (double)Height, 0.01, 100.0);

            //  Use the 'look at' helper function to position and aim the camera.
            gl.LookAt(-5, 5, -5, 0, 0, 0, 0, 1, 0);

            //  Set the modelview matrix.
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
        }

        private void openglControl1_OpenGLInitialized(object sender, EventArgs e)
        {
            //  Get the OpenGL object.
            OpenGL gl = this.openglControl1.OpenGL;

            //  Set the clear color.
            gl.ClearColor(0, 0, 0, 0);
        }
    }
}
