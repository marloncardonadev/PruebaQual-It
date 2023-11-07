import { NextResponse } from "next/server";

export async function GET(){
    const result = await fetch('http://localhost:5294/api/product/',{
        method:"GET",
        headers: {
            "Content-type": "application/json"
        }
    })
    const products = await result.json();
    return NextResponse.json({products})
}