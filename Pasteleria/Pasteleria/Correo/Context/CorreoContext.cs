namespace Pasteleria
{
    class CorreoContext
    {
        private CorreoStrategy _correo;

        public CorreoContext(CorreoStrategy correo)
        {
            this._correo = correo;
        }

        public void CorreoContextInterface(string correoDestino)
        {
            _correo.MandarCorreo(correoDestino);
        }
    }
}
