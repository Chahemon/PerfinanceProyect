import express from "express"
import conectarDB from "./config/db.js"
import dotenv from "dotenv"
import cors from 'cors'
import usuarioRoutes from './routes/usuarioRoutes.js'

const app = express()
app.use( express.json() )

dotenv.config()

conectarDB()

// Configurar CORS
const whitelist = ["http://127.0.0.1:5173"]

const corsOptions = {
    origin: function(origin, callback) {
        if ( whitelist.includes(origin) ) {
            // Puede consultar la API
            callback(null, true)
        } else {
            // No esta permitido
            callback(new Error("Error de Cors"))
        }
    }
}

app.use(cors(corsOptions))

app.use('/api/usuarios', usuarioRoutes) 

const PORT = process.env.PORT || 4000
app.listen(PORT, () => {
    console.log(`Servidor corriendo en el puerto ${PORT}`)
})