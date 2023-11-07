import { NextResponse } from "next/server";

export const GET = async () =>{
    const result = await fetch('http://localhost:5294/api/product/',{
        method:"GET",
        headers: {
            "Content-type": "application/json"
        }
    })
    const products = await result.json();
    return NextResponse.json({products})
}